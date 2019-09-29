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
            
            int p = GenPrimes.Gen(); //генерация простого числа
            int g = Antiderivative.findPrimitive(p); //генерация первообразного корня
            int x = Calculate.Rand(1, p-2); //генерация секретного ключа
            int y = Calculate.Power(g, x, p); //генерация открытого ключа
            // выводим итоги в форму
            textBoxP.Text = p.ToString();
            textBoxG.Text = g.ToString();
            textBoxX.Text = x.ToString();
            textBoxY.Text = y.ToString();
            buttonSend1.Enabled = true; //делаем активной следующую кнопку
        }

        private void ButtonSend1_Click(object sender, EventArgs e)
        {
            //выводим принятые данные в форму
            textBoxP2.Text = textBoxP.Text;
            textBoxG2.Text = textBoxG.Text;
            textBoxY2.Text = textBoxY.Text;
            buttonCrypt.Enabled = true; //делаем активной следующую кнопку
        }

        private void ButtonCrypt_Click(object sender, EventArgs e)
        {
            // вытаскиваем полученный открытый ключ из формы 
            int p = Int32.Parse(textBoxP2.Text); 
            int g = Int32.Parse(textBoxG2.Text);
            int y = Int32.Parse(textBoxY2.Text);

            int k = Calculate.GenSessionKey(p); //генерируем случайный сессионный ключ
            
            int a = Calculate.Power(g, k, p);// считаем первую посылку
            //считываем то, что нужно шифровать
            string originalText = textBoxOriginalText.Text;
            int M = 0;
            try
            {
                M = Int32.Parse(originalText);
            }
            catch
            {
                MessageBox.Show("Можно вводить только числа до 999!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int b = Calculate.Mul(Calculate.Power(y, k, p), M, p); //считаем вторую посылку
            // отображаем значения в форме
            textBoxK.Text = k.ToString();
            textBoxA.Text = a.ToString();
            textBoxB.Text = b.ToString();
            buttonSend2.Enabled = true; //делаем активной следующую кнопку
        }

        private void ButtonSend2_Click(object sender, EventArgs e)
        {
            // отображаем полученные посылки в форме
            textBoxA2.Text = textBoxA.Text;
            textBoxB2.Text = textBoxB.Text;
            buttonDecrypt.Enabled = true; //делаем активной следующую кнопку
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            //достаем посылки и необходимые ключи из формы
            int b = Int32.Parse(textBoxB2.Text);
            int a = Int32.Parse(textBoxA2.Text);
            int x = Int32.Parse(textBoxX.Text);
            int p = Int32.Parse(textBoxP.Text);
            int M = Calculate.Mul(b, Calculate.Power(a, p - 1 - x, p), p); //расшифровываем сообщение
            textBoxM.Text = M.ToString(); //выводим результат в форму
        }
    }
}
