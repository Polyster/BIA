using BIA.Library.Algorithms;
using BIA.Library.Functions;
using BIA.Library.Functions.Multimodal;
using BIA.Library.Functions.Unimodal;
using BIA.Library.Points;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BIA.GUI
{
    public partial class MainForm : Form
    {
        private PopulationManager popManager;
        private ILScene scene;
        private List<Individual> stubPopluation;
        private AbstractAlgorithm selectedAlgorithm;
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
            functionsBox.Items.Add( new FirstDeJongFunction( new float[] { -5.12f, -5.12f }, new float[] { 5.12f, 5.12f }) );
            functionsBox.SelectedIndex = 0; //Select first function to draw it
            functionsBox.Items.Add( new SecondDeJongFunction( new float[] { -5f, -5f }, new float[] { 5f, 5f }) );
            functionsBox.Items.Add( new ThirdDeJongFunction( new float[] { -2.048f, -2.048f }, new float[] { 2.048f, 2.048f } ) );
            functionsBox.Items.Add( new ForthDeJongFunction( new float[] { -1.28f, -1.28f } , new float[] { 1.28f, 1.28f } ) );

            //Multimodal functions
            functionsBox.Items.Add( new RastriginsFunction( new float[] { -5.12f, -5.12f } , new float[] { 5.12f, 5.12f } ) );
            functionsBox.Items.Add( new SchwefelsFunction( new float[] { -500f, -500f } , new float[] { 500f, 500f } ) );
            functionsBox.Items.Add( new GriewangksFunction( new float[] { -50f, -50f } , new float[] { 50f, 50f } ) );
            functionsBox.Items.Add( new SineEnvelopeSineWaveFunction( new float[] { -3f, -3f } , new float[] { 3f, 3f } ) );
            functionsBox.Items.Add( new StretchedVSineWaveFunction( new float[] { -10f, -10f } , new float[] { 10f, 10f } ) );
            functionsBox.Items.Add( new FirstAckleysFunction( new float[] { -20f, -20f } , new float[] { 20f, 20f } ) );
            functionsBox.Items.Add( new SecondAckleysFunction( new float[] { -30f, -30f } , new float[] { 30f, 30f } ) );
            functionsBox.Items.Add( new EggHolderFunction( new float[] { -512f, -512f } , new float[] { 512f, 512f } ) );
            functionsBox.Items.Add( new RanasFunction( new float[] { -500f, -500f } , new float[] { 500f, 500f } ) );
            functionsBox.Items.Add( new PathologicalFunction( new float[] { -100f, -100f } , new float[] { 100f, 100f } ) );
            functionsBox.Items.Add( new MichalewiczsFunction( new float[] { -(float)Math.PI, -(float)Math.PI } , new float[] { (float)Math.PI, (float)Math.PI } ) );
            functionsBox.Items.Add( new MastersCosineWaveFunction( new float[] { -5f, -5f } , new float[] { 5f, 5f } ) );
            functionsBox.Items.Add( new ParetoBorderFunction( new float[] { 0f, 0f } , new float[] { 1f, 1f } ) );

            //Algorithms
            algorithmBox.Items.Add( "Blind search" );
            algorithmBox.Items.Add( "Simulated annealing" );
            algorithmBox.Items.Add( "Differential evolution" );
            algorithmBox.Items.Add( "SOMA" );
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
                    Positions = ConvertToDrawable(population),
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
            for ( int i = 0; i < population.Count; i++ )
            {
                populationGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private ILArray<float> ConvertToDrawable( List<Individual> population )
        {
            ILArray<float> pop = ILMath.zeros<float>( 3, population.Count );
            for ( int i = 0; i < population.Count; i++ )
            {
                pop[0, i] = population[i].X;
                pop[1, i] = population[i].Y;
                pop[2, i] = population[i].Fitness;
            }
            return pop;
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
            float xmin = float.Parse( xMinBox.Text );
            float xmax = float.Parse( xMaxBox.Text );
            float ymin = float.Parse( yMinBox.Text );
            float ymax = float.Parse( yMaxBox.Text );
            float[] highBound = new float[] { xmax, ymax };
            float[] lowBound = new float[] { xmin, ymin };
            DrawFunction( selectedFunction, xmin, xmax, ymin, ymax );
            
            selectedFunction.HighBound = highBound;
            selectedFunction.LowBound = lowBound;

            ilPanel.Refresh();
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            stubPopluation = popManager.GeneratePopulation( selectedFunction, int.Parse(individualsTxtBox.Text) );
            DrawPopulation(stubPopluation);
            FillGridView(stubPopluation);
        }
        private void stepButton_Click(object sender, EventArgs e)
        {
            Action stepAction = new Action( () =>
            { 
                selectedAlgorithm.PopulationManager = popManager;
                selectedAlgorithm.Population?.Clear();
            
                selectedAlgorithm.Population = stubPopluation.Select( individual => (Individual)individual.Clone()).ToList();
                selectedAlgorithm.Execute( selectedFunction );
                stubPopluation?.Clear();
                stubPopluation = selectedAlgorithm.Population.Select( individual => (Individual)individual.Clone() ).ToList();

                DrawPopulation( selectedAlgorithm.Population );
                FillGridView( selectedAlgorithm.Population );
            } );
            this.Invoke( stepAction );
        }
        private  void playButton_Click(object sender, EventArgs e)
        {
            Action tAction = new Action(() => 
            {
                while ( !selectedAlgorithm.IsFinnished )
                {
                    stepButton_Click( sender, e );
                    Task.Delay(1000);
                }
            } );
            Task.Factory.StartNew(tAction);
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
                    selectedAlgorithm = new BlindSearchAlgorithm();
                    break;
                case 1:
                    Views.SimulatedAnnealingView simAnnealingView = new Views.SimulatedAnnealingView();
                    simAnnealingView.ShowDialog();
                    selectedAlgorithm = new SimulatedAnnealingAlgorithm(simAnnealingView.Temperature, simAnnealingView.FinalTemp, simAnnealingView.Radius);
                    break;
                case 2:
                    Views.DifferentialEvolutionView diffEvolutionView = new Views.DifferentialEvolutionView();
                    diffEvolutionView.Show();
                    selectedAlgorithm = new DifferentialEvolutionAlgorithm( diffEvolutionView.Generations, diffEvolutionView.CR, diffEvolutionView.F );
                    break;
                case 3:
                    Views.SomaView somaView = new Views.SomaView();
                    somaView.Show();
                    selectedAlgorithm = new SOMAAlgorithm(somaView.MaxGenerations, somaView.PathLength, somaView.Step, somaView.Perturbation );
                    break;

            }
        }
    }
}