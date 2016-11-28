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
    public partial class SomaView : Form
    {
        public int MaxGenerations = 200;
        public float Step = 0.3f;
        public float PathLength = 3f;
        public float Perturbation = 0.3f;
        public SomaView()
        {
            InitializeComponent();

            maxMigrationBox.Text = MaxGenerations.ToString();
            stepBox.Text = Step.ToString();
            pathLengthBox.Text = PathLength.ToString();
            perturbationBox.Text = Perturbation.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MaxGenerations = int.Parse(maxMigrationBox.Text);
            Step = float.Parse(stepBox.Text);
            PathLength = float.Parse(pathLengthBox.Text);
            Perturbation = float.Parse(perturbationBox.Text);
            this.Close();
        }
    }
}
