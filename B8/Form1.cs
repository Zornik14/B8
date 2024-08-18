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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void klijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klijenti kl = new Klijenti();
            kl.Show();
            this.Hide();
        }

        private void poRezervacijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_rezervacijama po = new Po_rezervacijama();
            po.Show();
            this.Hide();
        }
    }
}
