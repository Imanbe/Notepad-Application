namespace Note
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.manu_format = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pravka_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.manu_pravka_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.manu_pravka_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pravka_timedate = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_spravka = new System.Windows.Forms.ToolStripMenuItem();
            this.manu_spravka_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.st_bar_rws_clmms = new System.Windows.Forms.ToolStripStatusLabel();
            this.st_bar_decoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.manu_format,
            this.menu_pravka,
            this.menu_spravka});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_new_file,
            this.menu_file_open,
            this.menu_file_save,
            this.сохранитьКакToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.menu_file_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(59, 24);
            this.menu_file.Text = "Файл";
            // 
            // menu_file_new_file
            // 
            this.menu_file_new_file.Name = "menu_file_new_file";
            this.menu_file_new_file.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_file_new_file.Size = new System.Drawing.Size(282, 26);
            this.menu_file_new_file.Text = "Создать";
            this.menu_file_new_file.Click += new System.EventHandler(this.CreateNewDocument);
            // 
            // menu_file_open
            // 
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_file_open.Size = new System.Drawing.Size(282, 26);
            this.menu_file_open.Text = "Открыть";
            this.menu_file_open.Click += new System.EventHandler(this.OpenFile);
            // 
            // menu_file_save
            // 
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_file_save.Size = new System.Drawing.Size(282, 26);
            this.menu_file_save.Text = "Сохранить";
            this.menu_file_save.Click += new System.EventHandler(this.Save);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.onPrintClick);
            // 
            // menu_file_exit
            // 
            this.menu_file_exit.Name = "menu_file_exit";
            this.menu_file_exit.Size = new System.Drawing.Size(282, 26);
            this.menu_file_exit.Text = "Выход";
            this.menu_file_exit.Click += new System.EventHandler(this.onExitClick);
            // 
            // manu_format
            // 
            this.manu_format.Name = "manu_format";
            this.manu_format.Size = new System.Drawing.Size(77, 24);
            this.manu_format.Text = "Формат";
            this.manu_format.Click += new System.EventHandler(this.OnFontClick);
            // 
            // menu_pravka
            // 
            this.menu_pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_pravka_cut,
            this.manu_pravka_copy,
            this.manu_pravka_paste,
            this.menu_pravka_timedate});
            this.menu_pravka.Name = "menu_pravka";
            this.menu_pravka.Size = new System.Drawing.Size(74, 24);
            this.menu_pravka.Text = "Правка";
            // 
            // menu_pravka_cut
            // 
            this.menu_pravka_cut.Name = "menu_pravka_cut";
            this.menu_pravka_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_pravka_cut.Size = new System.Drawing.Size(227, 26);
            this.menu_pravka_cut.Text = "Вырезать";
            this.menu_pravka_cut.Click += new System.EventHandler(this.OnCutClick);
            // 
            // manu_pravka_copy
            // 
            this.manu_pravka_copy.Name = "manu_pravka_copy";
            this.manu_pravka_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.manu_pravka_copy.Size = new System.Drawing.Size(227, 26);
            this.manu_pravka_copy.Text = "Копировать";
            this.manu_pravka_copy.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // manu_pravka_paste
            // 
            this.manu_pravka_paste.Name = "manu_pravka_paste";
            this.manu_pravka_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.manu_pravka_paste.Size = new System.Drawing.Size(227, 26);
            this.manu_pravka_paste.Text = "Вставить";
            this.manu_pravka_paste.Click += new System.EventHandler(this.OnPastClick);
            // 
            // menu_pravka_timedate
            // 
            this.menu_pravka_timedate.Name = "menu_pravka_timedate";
            this.menu_pravka_timedate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menu_pravka_timedate.Size = new System.Drawing.Size(227, 26);
            this.menu_pravka_timedate.Text = "Время и дата";
            this.menu_pravka_timedate.Click += new System.EventHandler(this.TypeTimeAndData);
            // 
            // menu_spravka
            // 
            this.menu_spravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manu_spravka_about});
            this.menu_spravka.Name = "menu_spravka";
            this.menu_spravka.Size = new System.Drawing.Size(81, 24);
            this.menu_spravka.Text = "Справка";
            // 
            // manu_spravka_about
            // 
            this.manu_spravka_about.Name = "manu_spravka_about";
            this.manu_spravka_about.Size = new System.Drawing.Size(224, 26);
            this.manu_spravka_about.Text = "О программе";
            this.manu_spravka_about.Click += new System.EventHandler(this.onAboutClock);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.st_bar_rws_clmms,
            this.st_bar_decoding});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // st_bar_rws_clmms
            // 
            this.st_bar_rws_clmms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.st_bar_rws_clmms.Name = "st_bar_rws_clmms";
            this.st_bar_rws_clmms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.st_bar_rws_clmms.Size = new System.Drawing.Size(92, 20);
            this.st_bar_rws_clmms.Text = "стр 0, стлб 0";
            // 
            // st_bar_decoding
            // 
            this.st_bar_decoding.Name = "st_bar_decoding";
            this.st_bar_decoding.Size = new System.Drawing.Size(48, 20);
            this.st_bar_decoding.Text = "UTF-8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(0, 32);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(782, 392);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBoxChanging);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.Activated += new System.EventHandler(this.onFocus);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_file_new_file;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem menu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem manu_format;
        private System.Windows.Forms.ToolStripMenuItem menu_spravka;
        private System.Windows.Forms.ToolStripMenuItem manu_spravka_about;
        private System.Windows.Forms.ToolStripMenuItem menu_pravka;
        private System.Windows.Forms.ToolStripMenuItem menu_pravka_cut;
        private System.Windows.Forms.ToolStripMenuItem manu_pravka_copy;
        private System.Windows.Forms.ToolStripMenuItem manu_pravka_paste;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel st_bar_rws_clmms;
        private System.Windows.Forms.ToolStripStatusLabel st_bar_decoding;
        private System.Windows.Forms.ToolStripMenuItem menu_pravka_timedate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
    }
}
    

