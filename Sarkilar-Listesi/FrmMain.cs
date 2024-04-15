using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sarkilar_Listesi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Database=muzik;Uid=root;Pwd='';";
        private void FrmMain_Load(object sender, EventArgs e)
        {
           using(MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();
                string sorgu = "SELECT* FROM sarkilar";
                MySqlCommand cmd=new MySqlCommand(sorgu,baglanti);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dgvListe.DataSource = tablo;
            } 
        }
    }
}
