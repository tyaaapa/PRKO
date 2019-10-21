namespace PRKO
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.факультетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абитуриентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юридическийФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экономическийФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.торговыйФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информационныйФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.факультетыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.абитуриентыToolStripMenuItem,
            this.специальностиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // факультетыToolStripMenuItem
            // 
            this.факультетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.юридическийФакультетToolStripMenuItem,
            this.экономическийФакультетToolStripMenuItem,
            this.торговыйФакультетToolStripMenuItem,
            this.информационныйФакультетToolStripMenuItem});
            this.факультетыToolStripMenuItem.Name = "факультетыToolStripMenuItem";
            this.факультетыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.факультетыToolStripMenuItem.Text = "Факультеты";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // абитуриентыToolStripMenuItem
            // 
            this.абитуриентыToolStripMenuItem.Name = "абитуриентыToolStripMenuItem";
            this.абитуриентыToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.абитуриентыToolStripMenuItem.Text = "Абитуриенты";
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            // 
            // юридическийФакультетToolStripMenuItem
            // 
            this.юридическийФакультетToolStripMenuItem.Name = "юридическийФакультетToolStripMenuItem";
            this.юридическийФакультетToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.юридическийФакультетToolStripMenuItem.Text = "Юридический факультет";
            this.юридическийФакультетToolStripMenuItem.Click += new System.EventHandler(this.юридическийФакультетToolStripMenuItem_Click);
            // 
            // экономическийФакультетToolStripMenuItem
            // 
            this.экономическийФакультетToolStripMenuItem.Name = "экономическийФакультетToolStripMenuItem";
            this.экономическийФакультетToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.экономическийФакультетToolStripMenuItem.Text = "Экономический факультет";
            // 
            // торговыйФакультетToolStripMenuItem
            // 
            this.торговыйФакультетToolStripMenuItem.Name = "торговыйФакультетToolStripMenuItem";
            this.торговыйФакультетToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.торговыйФакультетToolStripMenuItem.Text = "Торговый факультет";
            // 
            // информационныйФакультетToolStripMenuItem
            // 
            this.информационныйФакультетToolStripMenuItem.Name = "информационныйФакультетToolStripMenuItem";
            this.информационныйФакультетToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.информационныйФакультетToolStripMenuItem.Text = "Информационный факультет";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 70);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem факультетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юридическийФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экономическийФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem торговыйФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информационныйФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абитуриентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}