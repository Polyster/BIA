using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIA.GUI.Views
{
    public partial class EvolutionaryStrategyView : Form
    {
        public int MaxGenerations = 200;
        public int Mutants = 20;
        public int ESVersion = 0;
        public double StdDeviation = 1;
        public EvolutionaryStrategyView()
        {
            InitializeComponent();
            this.maxGenerationsBox.Text= MaxGenerations.ToString();
            this.mutantsBox.Text = Mutants.ToString();
            this.stdDeviationBox.Text = StdDeviation.ToString();
            this.esVersionBox.Text = ESVersion.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            MaxGenerations = int.Parse(maxGenerationsBox.Text);
            Mutants = int.Parse(mutantsBox.Text);
            ESVersion = int.Parse(esVersionBox.Text);
            StdDeviation = double.Parse(stdDeviationBox.Text);
            this.Close();
        }
    }
}
