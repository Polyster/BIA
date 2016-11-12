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
    public partial class DifferentialEvolutionView : Form
    {
        public float CR = 0.5f;
        public float F = 0.8f;
        public int Generations = 100;
        public DifferentialEvolutionView()
        {
            InitializeComponent();
            crTxtBox.Text = CR.ToString();
            fTxtBox.Text = F.ToString();
            generationsTxtBox.Text = Generations.ToString();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            CR = float.Parse( crTxtBox.Text );
            F = float.Parse( fTxtBox.Text );
            Generations = int.Parse( generationsTxtBox.Text );
            this.Close();
        }
    }
}
