using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login2 : Form
    {
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
        }

        private void login2_Load(object sender, EventArgs e)
        {

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
