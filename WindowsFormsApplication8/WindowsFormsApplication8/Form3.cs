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
    public partial class Form3 : Form
    {
        SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form3()
        {
            InitializeComponent();
        }
        String resimPath;


        private void projeEkle_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Resim Aç";

            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                resimPath = openFileDialog1.FileName.ToString();

            }

        }

        private void projeKaydet_Click(object sender, EventArgs e)
        {



            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);



            BinaryReader br = new BinaryReader(fs);



            byte[] resim = br.ReadBytes((int)fs.Length);

            br.Close();

            fs.Close();




            SqlCommand kmt = new SqlCommand("insert into resimbil(isim,resim) Values ('"+txtKayıtAdı.Text+"',@image) ", bag);

            kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;

            try

            {

                bag.Open();

                kmt.ExecuteNonQuery();

                MessageBox.Show(" Veritabanına kayıt yapıldı.");

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

        private void mesajGönder_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd =new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText= "insert into mesaj(projeismi, projesahibi, mesaj,id) Values('" + txtProjeismi.Text + "', '" + txtProjeSahibi.Text + "', '" + txtMesaj.Text+"','1')";
   
               cmd.ExecuteNonQuery();
            cmd.Dispose();
            bag.Close();
            MessageBox.Show("Mesajınız Gönderilmiştir.");
            txtProjeismi.Text = "";
            txtProjeSahibi.Text = "";
            txtMesaj.Text = "";
        }

        private void gelenMesaj_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select mesaj,projeismi from Mesaj where id=2";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listGelenMesaj.HorizontalScrollbar = true;
                listGelenMesaj.Items.Add("Proje ismi: " + dr["projeismi"].ToString() + "   " +"  Gelen Mesaj: "+ dr["mesaj"].ToString());
            }

        }


    }

}