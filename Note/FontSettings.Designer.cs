namespace Note
{
    partial class FontSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Образец";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(77, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "AaBbYyZz";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.fontBox.Location = new System.Drawing.Point(23, 26);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(182, 24);
            this.fontBox.TabIndex = 2;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.onFontChange);
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "вычеркивание",
            "подчеркивание"});
            this.styleBox.Location = new System.Drawing.Point(230, 26);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(182, 24);
            this.styleBox.TabIndex = 3;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.onStyleChange);
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "красный",
            "синий",
            "зеленый",
            "желтый",
            "белый",
            "черный"});
            this.colorBox.Location = new System.Drawing.Point(435, 26);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(182, 24);
            this.colorBox.TabIndex = 4;
            this.colorBox.SelectedValueChanged += new System.EventHandler(this.onColorChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onSaveFontClick);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 550);
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "FontSettings";
            this.Text = "л";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Button button1;
    }
}