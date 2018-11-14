namespace WindowsFormsApplication8
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
            this.pctrboxResim = new System.Windows.Forms.PictureBox();
            this.projeEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.projeGör = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Label();
            this.cmbxAd = new System.Windows.Forms.ComboBox();
            this.Kayıtadı = new System.Windows.Forms.Label();
            this.txtKayıtadı = new System.Windows.Forms.TextBox();
            this.projeSil = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listbxGelenmesaj = new System.Windows.Forms.ListBox();
            this.Mesaj = new System.Windows.Forms.Label();
            this.İsmi = new System.Windows.Forms.Label();
            this.mesajGönder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtProjead = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtResimıd = new System.Windows.Forms.TextBox();
            this.resimId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrboxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrboxResim
            // 
            this.pctrboxResim.BackColor = System.Drawing.Color.Transparent;
            this.pctrboxResim.Location = new System.Drawing.Point(12, 50);
            this.pctrboxResim.Name = "pctrboxResim";
            this.pctrboxResim.Size = new System.Drawing.Size(500, 376);
            this.pctrboxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrboxResim.TabIndex = 0;
            this.pctrboxResim.TabStop = false;
            // 
            // projeEkle
            // 
            this.projeEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.projeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projeEkle.Location = new System.Drawing.Point(537, 25);
            this.projeEkle.Name = "projeEkle";
            this.projeEkle.Size = new System.Drawing.Size(222, 55);
            this.projeEkle.TabIndex = 1;
            this.projeEkle.Text = "Proje Ekle";
            this.projeEkle.UseVisualStyleBackColor = false;
            this.projeEkle.Click += new System.EventHandler(this.projeEkle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(537, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Proje Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.projeKaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // projeGör
            // 
            this.projeGör.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.projeGör.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeGör.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projeGör.Location = new System.Drawing.Point(537, 302);
            this.projeGör.Name = "projeGör";
            this.projeGör.Size = new System.Drawing.Size(222, 52);
            this.projeGör.TabIndex = 3;
            this.projeGör.Text = "Proje gör";
            this.projeGör.UseVisualStyleBackColor = false;
            this.projeGör.Click += new System.EventHandler(this.projeGör_Click);
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(242, 13);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(184, 31);
            this.Panel.TabIndex = 4;
            this.Panel.Text = "Admin Paneli";
            // 
            // cmbxAd
            // 
            this.cmbxAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxAd.FormattingEnabled = true;
            this.cmbxAd.Location = new System.Drawing.Point(537, 206);
            this.cmbxAd.Name = "cmbxAd";
            this.cmbxAd.Size = new System.Drawing.Size(222, 32);
            this.cmbxAd.TabIndex = 5;
            // 
            // Kayıtadı
            // 
            this.Kayıtadı.AutoSize = true;
            this.Kayıtadı.BackColor = System.Drawing.Color.Transparent;
            this.Kayıtadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtadı.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kayıtadı.Location = new System.Drawing.Point(569, 144);
            this.Kayıtadı.Name = "Kayıtadı";
            this.Kayıtadı.Size = new System.Drawing.Size(155, 24);
            this.Kayıtadı.TabIndex = 10;
            this.Kayıtadı.Text = "UML KAYIT ADI";
            // 
            // txtKayıtadı
            // 
            this.txtKayıtadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtadı.Location = new System.Drawing.Point(537, 171);
            this.txtKayıtadı.Name = "txtKayıtadı";
            this.txtKayıtadı.Size = new System.Drawing.Size(222, 29);
            this.txtKayıtadı.TabIndex = 9;
            // 
            // projeSil
            // 
            this.projeSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.projeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projeSil.Location = new System.Drawing.Point(537, 360);
            this.projeSil.Name = "projeSil";
            this.projeSil.Size = new System.Drawing.Size(222, 52);
            this.projeSil.TabIndex = 11;
            this.projeSil.Text = "Proje Sil";
            this.projeSil.UseVisualStyleBackColor = false;
            this.projeSil.Click += new System.EventHandler(this.projeSil_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(537, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 52);
            this.button5.TabIndex = 12;
            this.button5.Text = "Veritabanı yükle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.veritabanıYükle_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(350, 488);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 55);
            this.button6.TabIndex = 14;
            this.button6.Text = "Gelen Mesajları Gör";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.gelenMesaj_Click);
            // 
            // listbxGelenmesaj
            // 
            this.listbxGelenmesaj.FormattingEnabled = true;
            this.listbxGelenmesaj.Location = new System.Drawing.Point(12, 488);
            this.listbxGelenmesaj.Name = "listbxGelenmesaj";
            this.listbxGelenmesaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listbxGelenmesaj.Size = new System.Drawing.Size(317, 147);
            this.listbxGelenmesaj.TabIndex = 15;
            // 
            // Mesaj
            // 
            this.Mesaj.AutoSize = true;
            this.Mesaj.BackColor = System.Drawing.Color.Transparent;
            this.Mesaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mesaj.Location = new System.Drawing.Point(468, 537);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(35, 13);
            this.Mesaj.TabIndex = 24;
            this.Mesaj.Text = "Mesaj";
            // 
            // İsmi
            // 
            this.İsmi.AutoSize = true;
            this.İsmi.BackColor = System.Drawing.Color.Transparent;
            this.İsmi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.İsmi.Location = new System.Drawing.Point(451, 491);
            this.İsmi.Name = "İsmi";
            this.İsmi.Size = new System.Drawing.Size(52, 13);
            this.İsmi.TabIndex = 22;
            this.İsmi.Text = "Proje İsmi";
            // 
            // mesajGönder
            // 
            this.mesajGönder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mesajGönder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajGönder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesajGönder.Location = new System.Drawing.Point(684, 488);
            this.mesajGönder.Name = "mesajGönder";
            this.mesajGönder.Size = new System.Drawing.Size(75, 43);
            this.mesajGönder.TabIndex = 21;
            this.mesajGönder.Text = "Mesaj Gönder";
            this.mesajGönder.UseVisualStyleBackColor = false;
            this.mesajGönder.Click += new System.EventHandler(this.mesajGönder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(509, 537);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(250, 102);
            this.txtMesaj.TabIndex = 20;
            // 
            // txtProjead
            // 
            this.txtProjead.Location = new System.Drawing.Point(509, 488);
            this.txtProjead.Multiline = true;
            this.txtProjead.Name = "txtProjead";
            this.txtProjead.Size = new System.Drawing.Size(122, 28);
            this.txtProjead.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(537, 418);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(222, 52);
            this.button8.TabIndex = 25;
            this.button8.Text = "Proje Güncelle";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.projeGüncelle_Click);
            // 
            // txtResimıd
            // 
            this.txtResimıd.Location = new System.Drawing.Point(102, 25);
            this.txtResimıd.Name = "txtResimıd";
            this.txtResimıd.ReadOnly = true;
            this.txtResimıd.Size = new System.Drawing.Size(29, 20);
            this.txtResimıd.TabIndex = 26;
            this.txtResimıd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resimId
            // 
            this.resimId.AutoSize = true;
            this.resimId.BackColor = System.Drawing.Color.Transparent;
            this.resimId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resimId.Location = new System.Drawing.Point(9, 25);
            this.resimId.Name = "resimId";
            this.resimId.Size = new System.Drawing.Size(87, 18);
            this.resimId.TabIndex = 27;
            this.resimId.Text = "Resim ID=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication8.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 661);
            this.Controls.Add(this.resimId);
            this.Controls.Add(this.txtResimıd);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Mesaj);
            this.Controls.Add(this.İsmi);
            this.Controls.Add(this.mesajGönder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtProjead);
            this.Controls.Add(this.listbxGelenmesaj);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.projeSil);
            this.Controls.Add(this.Kayıtadı);
            this.Controls.Add(this.txtKayıtadı);
            this.Controls.Add(this.cmbxAd);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.projeGör);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.projeEkle);
            this.Controls.Add(this.pctrboxResim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrboxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrboxResim;
        private System.Windows.Forms.Button projeEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button projeGör;
        private System.Windows.Forms.Label Panel;
        private System.Windows.Forms.ComboBox cmbxAd;
        private System.Windows.Forms.Label Kayıtadı;
        private System.Windows.Forms.TextBox txtKayıtadı;
        private System.Windows.Forms.Button projeSil;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listbxGelenmesaj;
        private System.Windows.Forms.Label Mesaj;
        private System.Windows.Forms.Label İsmi;
        private System.Windows.Forms.Button mesajGönder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtProjead;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtResimıd;
        private System.Windows.Forms.Label resimId;
    }
}

