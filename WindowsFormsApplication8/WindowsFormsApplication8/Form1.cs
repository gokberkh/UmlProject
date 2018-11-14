using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.Data.SqlClient;

using System.IO;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {

            InitializeComponent();
        }
        String resimm;
        SqlDataAdapter adap1; //datadapter tanımladık dataseti doldurmak için
        DataSet dset;



        private void projeEkle_Click(object sender, EventArgs e)
        {
            //Filtreme yaptık , Yükleyecegimiz resmi picture boxta gösterdik
            openFileDialog1.Title = "Resim Aç";

            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                pctrboxResim.Image = Image.FromFile(openFileDialog1.FileName);
                pctrboxResim.SizeMode = PictureBoxSizeMode.StretchImage;

                resimm = openFileDialog1.FileName.ToString();

            }

        }

        private void projeKaydet_Click(object sender, EventArgs e)
        {
                
            //Resmimizi okuduktan sonra
            //textboxta ismini belirledik veritabanına yükledik.

            FileStream fs = new FileStream(resimm, FileMode.Open, FileAccess.Read);



            BinaryReader br = new BinaryReader(fs);



            byte[] resim = br.ReadBytes((int)fs.Length);

            br.Close();

            fs.Close();



            SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlCommand kmt = new SqlCommand("insert into resimbil(isim,resim) Values ('" + txtKayıtadı.Text + "',@image) ", bag);
            kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;

            try

            {

                bag.Open();

                kmt.ExecuteNonQuery();

                MessageBox.Show(" Veritabanına kayıt yapıldı.");
                txtKayıtadı.Text = "";

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message.ToString());

            }

            finally

            {

                bag.Close();

            }

        }

       

        private void projeGör_Click(object sender, EventArgs e)
        {
            //Filestream,Datarow ile veritabanından cektigimiz resimi picture boxa yükleyip gösterdik
            //isminide comboboxa yükleyip veritabanından cektik.
            //datatable ve datarow u kullanarak veritabanında  geziniyoruz datasetimize atıp veritabanınından doldurduk
            DataTable dataTable = dset.Tables[0];


            if (pctrboxResim.Image != null)
            {

                pctrboxResim.Image.Dispose();

            }





            foreach (DataRow dataRow in dataTable.Rows)
            {


                if (dataRow[2].ToString() == cmbxAd.SelectedItem.ToString())//database isim comboboxtaki isme esitse
                {
                    bag.Open();
                    SqlCommand kmt = new SqlCommand();
                    SqlDataReader oku;
                    
                    kmt.CommandText = "Select Id From resimbil where isim=@isim";
                    kmt.Parameters.Add(new SqlParameter("@isim", cmbxAd.SelectedItem.ToString()));
                    kmt.Connection = bag;//isme göre sorgu yaparak ıd'mizi textboxa cektik
                    oku = kmt.ExecuteReader();
                    while (oku.Read())
                    {
                        txtResimıd.Text=(oku["id"].ToString());
                    }
                  
                    bag.Close();

                    byte[] yaz = (byte[])dataRow[1];//byte dizisinden resmin oldugu satırı cektik

                    using (MemoryStream ms = new MemoryStream())
                    {   //memorystream fonksiyonuyla gösterdik pictureboxa 
                        ms.Write(yaz, 0, yaz.Length);
                        Image img = Image.FromStream(ms);
                        pctrboxResim.Image = img;

                        pctrboxResim.SizeMode = PictureBoxSizeMode.StretchImage;

                        pctrboxResim.Refresh();
                        

                    }

                }

            }
        }

        private void projeSil_Click(object sender, EventArgs e)
        {
            //veritabanına baglanıp isimleri cektik,
            //sectigimiz isme göre veritabanından isstedigimiz verileri sildik.
            //UYARI mesajı koyduk. önemli burada cünkü geri dönüşü olmayan bir işlem.
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            string secme = "select *from resimbil where isim=@isim";
            SqlCommand secmekomut = new SqlCommand(secme, conn);
            secmekomut.Parameters.AddWithValue("@isim", cmbxAd.SelectedItem);
            SqlDataAdapter da = new SqlDataAdapter(secmekomut);
            SqlDataReader dr = secmekomut.ExecuteReader();
            if (dr.Read())
            {
                string isim = dr["isim"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum) 
                {
                    string silmeSorgusu = "DELETE from resimbil where isim=@isim";
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn);
                    silKomutu.Parameters.AddWithValue("@isim", cmbxAd.SelectedItem);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    cmbxAd.Items.RemoveAt(cmbxAd.SelectedIndex);
                    pctrboxResim.Image = null;


                }
                
            }
        }

        private void veritabanıYükle_Click(object sender, EventArgs e)
        {
            //veritabanındaki herseyi cekip isim verilerini comboboxa ekledik..
            adap1 = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            adap1.SelectCommand = new SqlCommand("SELECT * FROM resimbil", conn);


            dset = new DataSet("dset");

            adap1.Fill(dset);

            DataTable dtable;

            dtable = dset.Tables[0];

            cmbxAd.Items.Clear();

            foreach (DataRow drow in dtable.Rows)
            {

                cmbxAd.Items.Add(drow[2].ToString());

                cmbxAd.SelectedIndex = 0;

            }
        }

        private void gelenMesaj_Click(object sender, EventArgs e)
        {
            //idye göre mesajları cektik kullanıcıdan gelen
            //mesajları listboxta göstterdik
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select mesaj,projesahibi,projeismi from Mesaj where id=1";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listbxGelenmesaj.HorizontalScrollbar = true;
                listbxGelenmesaj.Items.Add("Kimden: "+dr["projesahibi"].ToString()+"  "+" Proje_adi: "+dr["projeismi"].ToString()+"   Mesaj: "+dr["mesaj"].ToString());
            }
    
        }

        private void mesajGönder_Click(object sender, EventArgs e)
        {   
            //Yönetici mesaj gönderdi ıdye göre

            bag.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = "insert into mesaj(projeismi,mesaj,id) Values('" + txtProjead.Text + "', '" + txtMesaj.Text + "','2')";

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            bag.Close();
            MessageBox.Show("Mesajınız Gönderilmiştir.");
            txtProjead.Text = "";
            txtMesaj.Text = "";
        }

        private void projeGüncelle_Click(object sender, EventArgs e)
        {   //resmimizi güncellemek için ekledigimiz resmi
            //varolan resimle idye göre ismini resmini güncelledik
            DialogResult durum = MessageBox.Show(" Güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                byte[] img = null;
                FileStream fs = new FileStream(resimm, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                string Query = "update resimbil set isim=@name,resim=@img where Id=@id";
                bag.Open();
                SqlCommand cmd = new SqlCommand(Query, bag);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                cmd.Parameters.Add(new SqlParameter("@id", txtResimıd.Text));
                cmd.Parameters.Add(new SqlParameter("@name", txtKayıtadı.Text.ToString()));
                cmd.ExecuteNonQuery();
                bag.Close();

                MessageBox.Show("Projeniz Güncellendi.");
            }

        }
    }
        
    }

