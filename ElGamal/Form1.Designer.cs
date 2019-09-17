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
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
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
            this.panel2.Controls.Add(this.picComputer1);
            this.panel2.Controls.Add(this.btnKeyGen);
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
            // btnKeyGen
            // 
            this.btnKeyGen.Location = new System.Drawing.Point(41, 174);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(208, 35);
            this.btnKeyGen.TabIndex = 0;
            this.btnKeyGen.Text = "Генерация ключа";
            this.btnKeyGen.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picComputer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picComputer1;
        private System.Windows.Forms.Button btnKeyGen;
    }
}

