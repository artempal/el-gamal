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
            Random rnd = new Random();
            int p = GenPrimes.Gen(); 
            int g = Antiderivative.findPrimitive(p);
            int x = rnd.Next(1, p-2);
            double y = (Math.Pow(g, x) % p);
            textBoxP.Text = p.ToString();
            textBoxG.Text = g.ToString();
            textBoxX.Text = x.ToString();
            textBoxY.Text = y.ToString();
        }

        private void buttonSend1_Click(object sender, EventArgs e)
        {
            textBoxP2.Text = textBoxP.Text;
            textBoxG2.Text = textBoxG.Text;
            textBoxY2.Text = textBoxY.Text;
        }

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int p = Int32.Parse(textBoxP2.Text);
            int g = Int32.Parse(textBoxG2.Text);
            //int k = rnd.Next(2, p - 1);
            int k = 3;
            while (GetNODModul(k,p - 1) != 1)
            {
                k = rnd.Next(1, p - 2);
            }
            
            ulong a = (ulong)(Math.Pow(g, k) % p);
            int y = Int32.Parse(textBoxY2.Text);
            string originalText = textBoxOriginalText.Text;
            ulong M = UInt64.Parse(originalText);
            //int b = (int)((Math.Pow(y, k) * M) % p);
            ulong b = (ulong) (M * (Math.Pow(y, k) % p));
            textBoxK.Text = k.ToString();
            textBoxA.Text = a.ToString();
            textBoxB.Text = b.ToString();
        }
        public static int GetNODModul(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }
        private void buttonSend2_Click(object sender, EventArgs e)
        {
            textBoxA2.Text = textBoxA.Text;
            textBoxB2.Text = textBoxB.Text;
            ulong b = UInt64.Parse(textBoxB2.Text);
            ulong a = UInt64.Parse(textBoxA2.Text);
            int x = Int32.Parse(textBoxX.Text);
            int p = Int32.Parse(textBoxP.Text);
            // double M = (double)((b * Math.Pow(Math.Pow(a, x), (-1))) % p);
            //int M = (int)(b * (Math.Pow(a,p - 1 - x) % p));
            //int M = (int)((Math.Pow(a, -x) * b) % p);
            //int M = (int)(b * Math.Pow(a,p-1-x)) % p;
            ulong M = (ulong)(b / (Math.Pow(a, x) % p));
            textBoxM.Text = M.ToString();
        }
    }
}
