using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 fm1 = new Form1();
        Form3 fm3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {   
                MessageBox.Show("Giriş Başarılı");
                fm2.Close();
                fm1.Show();
                this.Hide();
                
                
            }

            if (textBox1.Text == "Lider" && textBox2.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                fm2.Close();
                fm3.Show();
                this.Hide();
                
            }
        }

       
    }
}
