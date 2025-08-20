using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txbTemperatura.Text == "")
            {
                MessageBox.Show("Digite temperatura!", "erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double temperatura = double.Parse(txbTemperatura.Text);
                if (temperatura < 15)
                {
                    pibResultado.Image = Properties.Resources.frio;
                    
                }
                else if (temperatura <30) 
                {
                    pibResultado.Image = Properties.Resources.sol;
                }
                else if(temperatura >30)
                {
                    pibResultado.Image= Properties.Resources.solzao;
                }

                lblData.Text = DateTime.Now.ToString();

               
            }


        }
    }
}
