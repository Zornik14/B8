using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B8
{
    public partial class Klijenti : Form
    {
        public Klijenti()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("KlijentID", textBox1.Text);
            parameters.Add("Ime",textBox2.Text);
            parameters.Add("Prezime", textBox3.Text);
            parameters.Add("Grad", textBox4.Text);
            parameters.Add("BrojTelefona", textBox5.Text);
            konekcija.newTableRecord("dbo.Klijent", parameters);
            MessageBox.Show("Uspesno ste uneli Klijenta!");
        }
    }
}
