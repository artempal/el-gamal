﻿namespace ElGamal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCrypt = new System.Windows.Forms.Button();
            this.textBoxOriginalText = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picComputer2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSend1 = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picComputer1 = new System.Windows.Forms.PictureBox();
            this.buttonKeyGen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSend2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDecryptText = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.buttonSend2);
            this.panel1.Controls.Add(this.textBoxB);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBoxA);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxK);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.buttonCrypt);
            this.panel1.Controls.Add(this.textBoxOriginalText);
            this.panel1.Controls.Add(this.textBoxY2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxG2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxP2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picComputer2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 719);
            this.panel1.TabIndex = 0;
            // 
            // buttonCrypt
            // 
            this.buttonCrypt.Location = new System.Drawing.Point(379, 466);
            this.buttonCrypt.Name = "buttonCrypt";
            this.buttonCrypt.Size = new System.Drawing.Size(208, 35);
            this.buttonCrypt.TabIndex = 17;
            this.buttonCrypt.Text = "Зашифровать";
            this.buttonCrypt.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginalText
            // 
            this.textBoxOriginalText.Location = new System.Drawing.Point(55, 394);
            this.textBoxOriginalText.Multiline = true;
            this.textBoxOriginalText.Name = "textBoxOriginalText";
            this.textBoxOriginalText.Size = new System.Drawing.Size(532, 66);
            this.textBoxOriginalText.TabIndex = 16;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(55, 342);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.ReadOnly = true;
            this.textBoxY2.Size = new System.Drawing.Size(100, 22);
            this.textBoxY2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "y";
            // 
            // textBoxG2
            // 
            this.textBoxG2.Location = new System.Drawing.Point(55, 260);
            this.textBoxG2.Name = "textBoxG2";
            this.textBoxG2.ReadOnly = true;
            this.textBoxG2.Size = new System.Drawing.Size(100, 22);
            this.textBoxG2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "g";
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(55, 220);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.ReadOnly = true;
            this.textBoxP2.Size = new System.Drawing.Size(100, 22);
            this.textBoxP2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Полученный ключ";
            // 
            // picComputer2
            // 
            this.picComputer2.Image = ((System.Drawing.Image)(resources.GetObject("picComputer2.Image")));
            this.picComputer2.Location = new System.Drawing.Point(236, 9);
            this.picComputer2.Name = "picComputer2";
            this.picComputer2.Size = new System.Drawing.Size(221, 171);
            this.picComputer2.TabIndex = 2;
            this.picComputer2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.textBoxDecryptText);
            this.panel2.Controls.Add(this.buttonDecrypt);
            this.panel2.Controls.Add(this.textBoxM);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textBoxB2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBoxA2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buttonSend1);
            this.panel2.Controls.Add(this.textBoxY);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxG);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picComputer1);
            this.panel2.Controls.Add(this.buttonKeyGen);
            this.panel2.Location = new System.Drawing.Point(723, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 719);
            this.panel2.TabIndex = 1;
            // 
            // buttonSend1
            // 
            this.buttonSend1.Location = new System.Drawing.Point(41, 388);
            this.buttonSend1.Name = "buttonSend1";
            this.buttonSend1.Size = new System.Drawing.Size(208, 35);
            this.buttonSend1.TabIndex = 10;
            this.buttonSend1.Text = "Отправить ключи";
            this.buttonSend1.UseVisualStyleBackColor = true;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(106, 347);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "y";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(106, 305);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(106, 265);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(100, 22);
            this.textBoxG.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "g";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(106, 225);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ReadOnly = true;
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "p";
            // 
            // picComputer1
            // 
            this.picComputer1.Image = ((System.Drawing.Image)(resources.GetObject("picComputer1.Image")));
            this.picComputer1.Location = new System.Drawing.Point(304, 9);
            this.picComputer1.Name = "picComputer1";
            this.picComputer1.Size = new System.Drawing.Size(216, 171);
            this.picComputer1.TabIndex = 1;
            this.picComputer1.TabStop = false;
            // 
            // buttonKeyGen
            // 
            this.buttonKeyGen.Location = new System.Drawing.Point(41, 174);
            this.buttonKeyGen.Name = "buttonKeyGen";
            this.buttonKeyGen.Size = new System.Drawing.Size(208, 35);
            this.buttonKeyGen.TabIndex = 0;
            this.buttonKeyGen.Text = "Генерация ключа";
            this.buttonKeyGen.UseVisualStyleBackColor = true;
            this.buttonKeyGen.Click += new System.EventHandler(this.ButtonKeyGen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "2)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "3)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "k";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(55, 478);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(100, 22);
            this.textBoxK.TabIndex = 20;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(57, 552);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(275, 22);
            this.textBoxA.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 552);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "a";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(55, 599);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(277, 22);
            this.textBoxB.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 599);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "b";
            // 
            // buttonSend2
            // 
            this.buttonSend2.Location = new System.Drawing.Point(355, 640);
            this.buttonSend2.Name = "buttonSend2";
            this.buttonSend2.Size = new System.Drawing.Size(208, 35);
            this.buttonSend2.TabIndex = 25;
            this.buttonSend2.Text = "Отправить a,b";
            this.buttonSend2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 649);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "4)";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(57, 549);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.ReadOnly = true;
            this.textBoxA2.Size = new System.Drawing.Size(275, 22);
            this.textBoxA2.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 549);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "a";
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(57, 599);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.ReadOnly = true;
            this.textBoxB2.Size = new System.Drawing.Size(277, 22);
            this.textBoxB2.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 599);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "b";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(386, 570);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.ReadOnly = true;
            this.textBoxM.Size = new System.Drawing.Size(275, 22);
            this.textBoxM.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(363, 570);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "M";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(453, 599);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(208, 35);
            this.buttonDecrypt.TabIndex = 29;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // textBoxDecryptText
            // 
            this.textBoxDecryptText.Location = new System.Drawing.Point(86, 640);
            this.textBoxDecryptText.Multiline = true;
            this.textBoxDecryptText.Name = "textBoxDecryptText";
            this.textBoxDecryptText.ReadOnly = true;
            this.textBoxDecryptText.Size = new System.Drawing.Size(532, 66);
            this.textBoxDecryptText.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(415, 602);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "5)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 754);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Шифрование методом Эль-Гамаля";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picComputer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picComputer1;
        private System.Windows.Forms.Button buttonKeyGen;
        private System.Windows.Forms.Button buttonCrypt;
        private System.Windows.Forms.TextBox textBoxOriginalText;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxG2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSend1;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSend2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDecryptText;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
    }
}

