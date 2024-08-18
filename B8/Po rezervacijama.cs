using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B8
{
    public partial class Po_rezervacijama : Form
    {
        public Po_rezervacijama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            string connectionstring = @"Data Source = DESKTOP-R0GJOHE\SQLEXPRESS;Initial Catalog = B8;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("SELECT Naziv,Kategorija FROM Hotel", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listView1.Columns.Add("Naziv", 150);
                    listView1.Columns.Add("Kategorija", 150);

                    napunilw(reader[0].ToString(), reader[1].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        public void napunilw(string Naziv, string Kategorija)
        {
            string[] row = { Naziv,Kategorija};
            ListViewItem viewItem = new ListViewItem(row);
            listView1.Items.Add(viewItem);
        }
    }
}
