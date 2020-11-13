namespace WinForm
{
    partial class MainMenu
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
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.ürünToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriListesiToolStripMenuItem,
            this.ürünListesiToolStripMenuItem});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // kategoriListesiToolStripMenuItem
            // 
            this.kategoriListesiToolStripMenuItem.Name = "kategoriListesiToolStripMenuItem";
            this.kategoriListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriListesiToolStripMenuItem.Text = "Kategori Listesi";
            this.kategoriListesiToolStripMenuItem.Click += new System.EventHandler(this.KategoriListesiToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünListesiToolStripMenuItem.Text = "Kategori Ekle";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.ÜrünListesiToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünListesiToolStripMenuItem1});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // ürünListesiToolStripMenuItem1
            // 
            this.ürünListesiToolStripMenuItem1.Name = "ürünListesiToolStripMenuItem1";
            this.ürünListesiToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.ürünListesiToolStripMenuItem1.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem1.Click += new System.EventHandler(this.ÜrünListesiToolStripMenuItem1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem1;
    }
}

