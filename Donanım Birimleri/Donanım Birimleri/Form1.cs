using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donanım_Birimleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            secim = listBox1.SelectedItem.ToString();
            if (secim == "Klavye" || secim == "Mouse" || secim == "Kamera" || secim == "Tarayıcı")
            {
                MessageBox.Show("Bu Parça Giriş Birimidir");
            }
            if (secim == "Projeksiyon" || secim == "Yazıcı" || secim == "Hoparlör") 
            {
                MessageBox.Show("Bu Parça Çıkış Birimidir");
            }
        }
    }
}
