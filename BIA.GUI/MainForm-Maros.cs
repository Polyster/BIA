using BIA.Algorithms;
using BIA.Functions;
using BIA.Functions.Multimodal;
using BIA.Functions.Unimodal;
using BIA.Points;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BIA
{
    public partial class MainForm : Form
    {
        private PopulationManager popManager;
        private ILScene scene;
        private List<Individual> stubPopluation;
        private AbstractAlgorithm algorithm;
        private AbstractFunction selectedFunction;
        public MainForm()
        {
            InitializeComponent();
            Init();

            popManager = new PopulationManager(2);
            stubPopluation = new List<Individual>();
        }
        private void Init()
        {
            //Unimodal functions
            functionsBox.Items.Add( new FirstDeJongFunction() );
            functionsBox.SelectedIndex = 0; //Select first function to draw it
            functionsBox.Items.Add( new SecondDeJongFunction() );
            functionsBox.Items.Add( new ThirdDeJongFunction() );
            functionsBox.Items.Add( new ForthDeJongFunction() );

            //Multimodal functions
            functionsBox.Items.Add( new RastriginsFunction() );
            functionsBox.Items.Add( new SchwefelsFunction() );
            functionsBox.Items.Add( new GriewangksFunction() );
            functionsBox.Items.Add( new SineEnvelopeSineWaveFunction() );
            functionsBox.Items.Add( new StretchedVSineWaveFunction() );
            functionsBox.Items.Add( new FirstAckleysFunction() );
            functionsBox.Items.Add( new SecondAckleysFunction() );
            functionsBox.Items.Add( new EggHolderFunction() );
            functionsBox.Items.Add( new RanasFunction() );
            functionsBox.Items.Add( new PathologicalFunction() );
            functionsBox.Items.Add( new MichalewiczsFunction() );
            functionsBox.Items.Add( new MastersCosineWaveFunction() );
            functionsBox.Items.Add( new ParetoBorderFunction() );

            //Algorithms
            algorithmBox.Items.Add( "Blind search" );
            algorithmBox.Items.Add( "Simulated annealing" );
            algorithmBox.Items.Add( "Differential evolution" );
        }
        private void DrawFunction(AbstractFunction function, float xmin, float xmax, float ymin, float ymax)
        {
            scene = new ILScene()
            {
                new ILPlotCube(twoDMode: false)
                {
                    new ILSurface
                    (
                        function.CostFunction3D(),
                        xmax: xmax,
                        xmin: xmin,
                        ymax: ymax,
                        ymin: ymin,
                        xlen: 150,
                        ylen: 150,
                        colormap: Colormaps.Hsv
                    )
                }
            };
            scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(new Vector3(1, 0, 0), Math.PI / 2); // default rotation of camera
            ilPanel.Scene = scene;
        }
        private void DrawPopulation(List<Individual> population)
        {
            //To re-draw population on Plot it is necessary to remove previous one before doing so
            if (scene.First<ILPoints>() != null)
                scene.First<ILPlotCube>().Remove(scene.First<ILPoints>());

            scene.First<ILPlotCube>().Add
            (
                new ILPoints
                {
                    Positions = popManager.ConvertToDrawable(population),
                    Color = Color.Black,
                    Size = 10
                }
            );
            ilPanel.Refresh();
        }
        private void FillGridView(List<Individual> population)
        {
            populationGridView.DataSource = null;
            populationGridView.DataSource = population;
            for (int i = 0; i < population.Count; i++)
            {
                populationGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        //Events
        private void functionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var funcBox = sender as ComboBox;
            if (funcBox != null)
            {
                selectedFunction = funcBox.SelectedItem as AbstractFunction;
                xMinBox.Text = selectedFunction.Xmin.ToString();
                xMaxBox.Text = selectedFunction.Xmax.ToString();
                yMinBox.Text = selectedFunction.Ymin.ToString();
                yMaxBox.Text = selectedFunction.Ymax.ToString();
                DrawFunction( selectedFunction, selectedFunction.Xmin, selectedFunction.Xmax, selectedFunction.Ymin, selectedFunction.Ymax);
                ilPanel.Refresh();
            }
        }
        private void drawBtn_Click(object sender, EventArgs e)
        {
            //selectedFunction = functionsBox.SelectedItem as AbstractFunction;
            
            DrawFunction( selectedFunction, float.Parse(xMinBox.Text), float.Parse(xMaxBox.Text),
                        float.Parse(yMinBox.Text), float.Parse(yMaxBox.Text));
            popManager.SetBorders(float.Parse(xMinBox.Text), float.Parse(xMaxBox.Text),
                                  float.Parse(yMinBox.Text), float.Parse(yMaxBox.Text));
            ilPanel.Refresh();
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            //selectedFunction = functionsBox.SelectedItem as AbstractFunction;
            popManager.SetBorders(float.Parse(xMinBox.Text), float.Parse(xMaxBox.Text),
                                  float.Parse(yMinBox.Text), float.Parse(yMaxBox.Text));
            
            stubPopluation = popManager.GeneratePopulation( selectedFunction, int.Parse(individualsTxtBox.Text) );
            DrawPopulation(stubPopluation);
            FillGridView(stubPopluation);
        }
        private void stepButton_Click(object sender, EventArgs e)
        {
            //selectedFunction = functionsBox.SelectedItem as AbstractFunction;

            algorithm.PopulationManager = popManager;
            algorithm.Population = stubPopluation;
            algorithm.Algorithm( selectedFunction );
            stubPopluation = algorithm.Population;

            DrawPopulation(algorithm.Population);
            FillGridView(algorithm.Population);
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            //Task myTask = Task.Run( () =>
            // {
                 
            // } );
            while ( !algorithm.IsFinnished )
                stepButton_Click( sender, e );
        }
        private void dshValuesChecked_CheckedChanged( object sender, EventArgs e )
        {
            popManager.DSHVaules = dshValuesChecked.Checked;
        }

        private void algorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algBox = sender as ComboBox;

            switch (algBox.SelectedIndex)
            {
                case 0:
                    algorithm = new BlindSearchAlgorithm();
                    break;
                case 1:
                    Views.SimulatedAnnealingView simAnnealingView = new Views.SimulatedAnnealingView();
                    simAnnealingView.ShowDialog();
                    algorithm = new SimulatedAnnealingAlgorithm(simAnnealingView.Temperature, simAnnealingView.FinalTemp, simAnnealingView.Radius);
                    break;
                case 2:
                    Views.DifferentialEvolutionView difEvolutionView = new Views.DifferentialEvolutionView();
                    difEvolutionView.Show();
                    algorithm = new DifferentialEvolutionAlgorithm( difEvolutionView.Generations, difEvolutionView.CR, difEvolutionView.F );
                    break;

            }
        }
    }
}