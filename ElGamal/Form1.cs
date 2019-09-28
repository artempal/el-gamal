using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  

        private void ButtonKeyGen_Click(object sender, EventArgs e)
        {
            int p = GenPrimes.Gen(); 
            int g = Antiderivative.findPrimitive(p);
            textBoxP.Text = p.ToString();
            textBoxG.Text = g.ToString();
        }
    }
}
