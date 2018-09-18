using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_LinkedQueueStack
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private Kat_Ust uKat;
        private Kat_Zemin zKat;
        private Kat_Bodrum bKat;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            uKat = new Kat_Ust();
            zKat = new Kat_Zemin(15);
            bKat = new Kat_Bodrum(15);

            ArabalariEkle();           
        }


        private void ArabalariEkle()
        {
            Araba yeniAraba;
            string[] renkler = { "Yeşil", "Kırmızı", "Beyaz", "Siyah", "Turkuaz",
                                 "Sarı", "Gri", "Mavi", "Mor", "Kahrevengi",
                                 "İnci", "Bordo", "Lacivert", "Turuncu", "Pembe" };  // araba renkleri

            for (int kat = 1; kat >= -1; kat--)
            {
                for (int renk = 0; renk < 15; renk++)
                {
                    switch (kat)
                    {
                        case 1:
                            yeniAraba = new Araba();
                            yeniAraba.ad = "UKat-" + renkler[renk];  // Üst Kat için -> UKat-Sarı...
                            uKat.InsertFirst(yeniAraba);
                            lstUstKat.Items.Add(yeniAraba.ad);
                            break;

                        case 0:
                            yeniAraba = new Araba();
                            yeniAraba.ad = "ZKat-" + renkler[renk];  // Zemin Kat için -> ZKat-Sarı...
                            zKat.Insert(yeniAraba);
                            lstZeminKat.Items.Add(yeniAraba.ad);
                            break;

                        default:
                            yeniAraba = new Araba();
                            yeniAraba.ad = "BKat-" + renkler[renk]; // Bodrum Kat için -> BKat-Sarı...
                            bKat.Push(yeniAraba);
                            lstBodrumKat.Items.Add(yeniAraba.ad);
                            break;
                    }
                }
            }
        }
    }
}
