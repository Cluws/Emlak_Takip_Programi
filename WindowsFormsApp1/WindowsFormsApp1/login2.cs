using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class login2 : Form
    {
        MySqlConnection baglanti = new MySqlConnection(
                "Server=localhost;Database=emlak;Uid=root;Pwd=12345;"
                );
        public login2()
        {
            InitializeComponent();


            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "name";
            dataGridView1.Columns[1].Name = "surname";
            dataGridView1.Columns[2].Name = "ev turu";
            dataGridView1.Columns[3].Name = "adres";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnemlak_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string soyad = textBox2.Text;
            string ev_turu = comboBox1.Text;
            string adres = comboBox2.Text;
            dataGridView1.Rows.Add(isim, soyad,ev_turu,adres);

            try
            {
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into emlak1(isim,soyadi,evturu,adres)" +
                    "values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "');";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }


        }

        private void login2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
