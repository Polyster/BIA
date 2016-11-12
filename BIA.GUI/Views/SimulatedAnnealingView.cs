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
    public partial class SimulatedAnnealingView : Form
    {
        public float Temperature = 100f;
        public float Radius = 0.3f;
        public float FinalTemp = 0.1f;
        public SimulatedAnnealingView()
        {
            InitializeComponent();
            radiusBox.Text = Radius.ToString();
            tempBox.Text = Temperature.ToString();
            fTempBox.Text = FinalTemp.ToString();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Radius = float.Parse(radiusBox.Text);
            Temperature = float.Parse( tempBox.Text );
            FinalTemp = float.Parse( fTempBox.Text );
            this.Close();
        }
    }
}
