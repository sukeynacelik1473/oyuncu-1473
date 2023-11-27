using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyuncu_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

           
        }

        private void btnTıkla_Click(object sender, EventArgs e)
        {
            oyuncu oyuncu1 = new oyuncu();
            oyuncu1.Id = "4785788757857";
            oyuncu1.ad = "sukeyna";
            oyuncu1.soyad = "celik";
            oyuncu1.posta = "sukeynacelik05@gmail.com";
            oyuncu1.puan = 100;
            oyuncu1.kayıtTarihi = DateTime.Now;
            oyuncu1.aktif = false;


            MessageBox.Show("ad:" + oyuncu1.ad + "\npuan:"
                           + oyuncu1.puan + "\nAktif:"
                           + oyuncu1.aktif);

        }
    }
}
