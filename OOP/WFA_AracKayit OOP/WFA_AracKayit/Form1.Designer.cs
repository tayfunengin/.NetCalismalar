namespace WFA_AracKayit
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAracKaydet = new System.Windows.Forms.Button();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.cmbKasa = new System.Windows.Forms.ComboBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Ekleme Formu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(252, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 554);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araç Listeleme";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 503);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yakıt";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kasa Tip";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vites";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Renk";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Model Yıl";
            this.columnHeader7.Width = 92;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRenk);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnAracEkle);
            this.groupBox2.Controls.Add(this.btnAracKaydet);
            this.groupBox2.Controls.Add(this.cmbVites);
            this.groupBox2.Controls.Add(this.cmbKasa);
            this.groupBox2.Controls.Add(this.cmbYakit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbModel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbMarka);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(7, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 554);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 369);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(10, 490);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(213, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Araç Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAracKaydet
            // 
            this.btnAracKaydet.Location = new System.Drawing.Point(10, 398);
            this.btnAracKaydet.Name = "btnAracKaydet";
            this.btnAracKaydet.Size = new System.Drawing.Size(213, 35);
            this.btnAracKaydet.TabIndex = 2;
            this.btnAracKaydet.Text = "Araç Kaydet";
            this.btnAracKaydet.UseVisualStyleBackColor = true;
            this.btnAracKaydet.Click += new System.EventHandler(this.BtnAracKaydet_Click);
            // 
            // cmbVites
            // 
            this.cmbVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.cmbVites.Location = new System.Drawing.Point(10, 266);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(213, 24);
            this.cmbVites.TabIndex = 1;
            // 
            // cmbKasa
            // 
            this.cmbKasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKasa.FormattingEnabled = true;
            this.cmbKasa.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback"});
            this.cmbKasa.Location = new System.Drawing.Point(10, 212);
            this.cmbKasa.Name = "cmbKasa";
            this.cmbKasa.Size = new System.Drawing.Size(213, 24);
            this.cmbKasa.TabIndex = 1;
            // 
            // cmbYakit
            // 
            this.cmbYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(10, 164);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(213, 24);
            this.cmbYakit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Model Yıl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vites Tip";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(9, 116);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(213, 24);
            this.cmbModel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kasa Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yakıt Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model Seçin:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(9, 64);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(213, 24);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Seçin:";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(9, 439);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(213, 35);
            this.btnAracEkle.TabIndex = 2;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.BtnAracEkle_Click);
            // 
            // cmbRenk
            // 
            this.cmbRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(10, 314);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(207, 24);
            this.cmbRenk.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAracKaydet;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.ComboBox cmbKasa;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.ComboBox cmbRenk;
    }
}

