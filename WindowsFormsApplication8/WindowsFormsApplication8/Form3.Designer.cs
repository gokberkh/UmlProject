namespace WindowsFormsApplication8
{
    partial class Form3
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
            this.projeKaydet = new System.Windows.Forms.Button();
            this.projeEkle = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtKayıtAdı = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Label();
            this.txtProjeismi = new System.Windows.Forms.TextBox();
            this.txtProjeSahibi = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.mesajGönder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listGelenMesaj = new System.Windows.Forms.ListBox();
            this.gelenMesaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // projeKaydet
            // 
            this.projeKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.projeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projeKaydet.Location = new System.Drawing.Point(530, 113);
            this.projeKaydet.Name = "projeKaydet";
            this.projeKaydet.Size = new System.Drawing.Size(222, 55);
            this.projeKaydet.TabIndex = 6;
            this.projeKaydet.Text = "Proje Kaydet";
            this.projeKaydet.UseVisualStyleBackColor = false;
            this.projeKaydet.Click += new System.EventHandler(this.projeKaydet_Click);
            // 
            // projeEkle
            // 
            this.projeEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.projeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projeEkle.Location = new System.Drawing.Point(530, 52);
            this.projeEkle.Name = "projeEkle";
            this.projeEkle.Size = new System.Drawing.Size(222, 55);
            this.projeEkle.TabIndex = 5;
            this.projeEkle.Text = "Proje Ekle";
            this.projeEkle.UseVisualStyleBackColor = false;
            this.projeEkle.Click += new System.EventHandler(this.projeEkle_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(5, 52);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(519, 374);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // txtKayıtAdı
            // 
            this.txtKayıtAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtAdı.Location = new System.Drawing.Point(530, 207);
            this.txtKayıtAdı.Name = "txtKayıtAdı";
            this.txtKayıtAdı.Size = new System.Drawing.Size(222, 29);
            this.txtKayıtAdı.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(571, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "UML KAYIT ADI";
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(215, 9);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(213, 31);
            this.Panel.TabIndex = 9;
            this.Panel.Text = "Kullanıcı Paneli";
            // 
            // txtProjeismi
            // 
            this.txtProjeismi.Location = new System.Drawing.Point(98, 432);
            this.txtProjeismi.Multiline = true;
            this.txtProjeismi.Name = "txtProjeismi";
            this.txtProjeismi.Size = new System.Drawing.Size(122, 28);
            this.txtProjeismi.TabIndex = 10;
            // 
            // txtProjeSahibi
            // 
            this.txtProjeSahibi.Location = new System.Drawing.Point(98, 466);
            this.txtProjeSahibi.Multiline = true;
            this.txtProjeSahibi.Name = "txtProjeSahibi";
            this.txtProjeSahibi.Size = new System.Drawing.Size(122, 25);
            this.txtProjeSahibi.TabIndex = 11;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(98, 497);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(250, 117);
            this.txtMesaj.TabIndex = 12;
            // 
            // mesajGönder
            // 
            this.mesajGönder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mesajGönder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajGönder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesajGönder.Location = new System.Drawing.Point(273, 432);
            this.mesajGönder.Name = "mesajGönder";
            this.mesajGönder.Size = new System.Drawing.Size(75, 47);
            this.mesajGönder.TabIndex = 13;
            this.mesajGönder.Text = "Mesaj Gönder";
            this.mesajGönder.UseVisualStyleBackColor = false;
            this.mesajGönder.Click += new System.EventHandler(this.mesajGönder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Proje İsmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Proje Sahibi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mesaj";
            // 
            // listGelenMesaj
            // 
            this.listGelenMesaj.FormattingEnabled = true;
            this.listGelenMesaj.Location = new System.Drawing.Point(398, 441);
            this.listGelenMesaj.Name = "listGelenMesaj";
            this.listGelenMesaj.Size = new System.Drawing.Size(332, 173);
            this.listGelenMesaj.TabIndex = 19;
            // 
            // gelenMesaj
            // 
            this.gelenMesaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gelenMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelenMesaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gelenMesaj.Location = new System.Drawing.Point(736, 441);
            this.gelenMesaj.Name = "gelenMesaj";
            this.gelenMesaj.Size = new System.Drawing.Size(87, 50);
            this.gelenMesaj.TabIndex = 18;
            this.gelenMesaj.Text = "Gelen Mesajları Gör";
            this.gelenMesaj.UseVisualStyleBackColor = false;
            this.gelenMesaj.Click += new System.EventHandler(this.gelenMesaj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 652);
            this.Controls.Add(this.listGelenMesaj);
            this.Controls.Add(this.gelenMesaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mesajGönder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtProjeSahibi);
            this.Controls.Add(this.txtProjeismi);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKayıtAdı);
            this.Controls.Add(this.projeKaydet);
            this.Controls.Add(this.projeEkle);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button projeKaydet;
        private System.Windows.Forms.Button projeEkle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtKayıtAdı;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Panel;
        private System.Windows.Forms.TextBox txtProjeismi;
        private System.Windows.Forms.TextBox txtProjeSahibi;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button mesajGönder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listGelenMesaj;
        private System.Windows.Forms.Button gelenMesaj;
    }
}