namespace Note
{
    partial class AboutProgramm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTechnicalPos1 = new System.Windows.Forms.Label();
            this.labelTechnicalPos2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Note.Properties.Resources.кружка2;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(217, 225);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(136, 31);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Notepad";
            // 
            // labelTechnicalPos1
            // 
            this.labelTechnicalPos1.AutoSize = true;
            this.labelTechnicalPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechnicalPos1.Location = new System.Drawing.Point(45, 269);
            this.labelTechnicalPos1.Name = "labelTechnicalPos1";
            this.labelTechnicalPos1.Size = new System.Drawing.Size(425, 20);
            this.labelTechnicalPos1.TabIndex = 3;
            this.labelTechnicalPos1.Text = "Технические возможности тектового редактора:";
            // 
            // labelTechnicalPos2
            // 
            this.labelTechnicalPos2.AutoSize = true;
            this.labelTechnicalPos2.Location = new System.Drawing.Point(46, 289);
            this.labelTechnicalPos2.Name = "labelTechnicalPos2";
            this.labelTechnicalPos2.Size = new System.Drawing.Size(363, 16);
            this.labelTechnicalPos2.TabIndex = 3;
            this.labelTechnicalPos2.Text = "1. Работа с файлами(открытие, сохранение, создание)";
            this.labelTechnicalPos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "2. Работа с текстом(копирование, вставка, вырезка, вставка даты и времени)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "3. Работа со шрифтом(размер, цвет и стиль текста)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "4. Печать файла";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Баги, обнаруженные на данный момент:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "1. Копирование текста с измененным шрифтом приводит к";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "сбросу шрифта текста (шрифт становится по умолчанию)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTechnicalPos2);
            this.Controls.Add(this.labelTechnicalPos1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "AboutProgramm";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTechnicalPos1;
        private System.Windows.Forms.Label labelTechnicalPos2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}