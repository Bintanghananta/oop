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

namespace PUNYAHANANTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=barang";
            string query = "INSERT INTO tbl_barang(kode,nama,stok,harga)VALUES('" + this.Kode.Text + "','" + this.Nama.Text + "','" + this.Stok.Text + "','" + this.Harga.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Berhasil Disimpan");
            conn.Close();
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=barang";
            string query = "UPDATE tbl_barang SET nama='"+ this.Nama.Text + "', stok='" + this.Stok.Text +"',  harga='" + this.Harga.Text + "' WHERE kode='" + this.Kode.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=barang";
            string query = "SELECT * FROM tbl_barang";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt; 

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=barang";
            string query = "DELETE FROM  tbl_barang WHERE KODE='" + this.Kode.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully deleted!!");
            conn.Close();
        }

        private void Cari_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=barang";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM tbl_barang WHERE nama LIKE'" + this.Cari.Text +"%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=barang";
            string query = "SELECT * FROM tbl_barang";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void E(object sender, EventArgs e)
        {

        }
    }
}
