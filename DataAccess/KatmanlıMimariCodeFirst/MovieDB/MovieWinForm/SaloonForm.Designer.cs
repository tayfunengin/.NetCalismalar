namespace MovieWinForm
{
    partial class SaloonForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSaloon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(21, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 476);
            this.panel1.TabIndex = 5;
            // 
            // cmbSaloon
            // 
            this.cmbSaloon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaloon.FormattingEnabled = true;
            this.cmbSaloon.Location = new System.Drawing.Point(21, 28);
            this.cmbSaloon.Name = "cmbSaloon";
            this.cmbSaloon.Size = new System.Drawing.Size(108, 21);
            this.cmbSaloon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Saloon:";
            // 
            // SaloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSaloon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaloonForm";
            this.Text = "SaloonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSaloon;
        private System.Windows.Forms.Label label1;
    }
}