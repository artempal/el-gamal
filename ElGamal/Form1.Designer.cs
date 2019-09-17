namespace ElGamal
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
            this.picComputer2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picComputer1 = new System.Windows.Forms.PictureBox();
            this.buttonKeyGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOriginalText = new System.Windows.Forms.TextBox();
            this.buttonCrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
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
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(106, 225);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ReadOnly = true;
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 3;
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
            // buttonSend1
            // 
            this.buttonSend1.Location = new System.Drawing.Point(41, 388);
            this.buttonSend1.Name = "buttonSend1";
            this.buttonSend1.Size = new System.Drawing.Size(208, 35);
            this.buttonSend1.TabIndex = 10;
            this.buttonSend1.Text = "Отправить";
            this.buttonSend1.UseVisualStyleBackColor = true;
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
            // textBoxOriginalText
            // 
            this.textBoxOriginalText.Location = new System.Drawing.Point(55, 394);
            this.textBoxOriginalText.Multiline = true;
            this.textBoxOriginalText.Name = "textBoxOriginalText";
            this.textBoxOriginalText.Size = new System.Drawing.Size(532, 66);
            this.textBoxOriginalText.TabIndex = 16;
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
    }
}

