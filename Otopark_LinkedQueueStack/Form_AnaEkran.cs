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
            btnCikar.Enabled = false;
            btnHesapla.Enabled = false;
        }

        private Kat_Ust uKat;
        private Kat_Zemin zKat;
        private Kat_Bodrum bKat;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Liste_VarsayilanRenkler();
            btnHesapla.Enabled = false;
            btnCikar.Enabled = true;
            btnEkle.Enabled = false;

            IlgiliNesneleriUret();
            ArabalariEkle();
            ArabalariListele();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            btnEkle.Enabled = false;
            btnHesapla.Enabled = true;

            if (!zKat.IsEmpty())
            {
                ListeTemizle();
                Random rand = new Random();
                string[] katlar = { "ustkat", "bodrumkat" };
                string cikacakKat = katlar[rand.Next(2)];
                cikacakKat = KatlariKontrolEt(cikacakKat);

                Araba cikanArabaZK = zKat.Remove();
                lstCikanZK.Items.Add(cikanArabaZK.ad);

                switch (cikacakKat)
                {
                    case "ustkat":
                        Node cikanDugum = uKat.Delete();
                        Araba cikanArabaUK = cikanDugum.Data;
                        lstCikanUK.Items.Add(cikanArabaUK.ad);
                        lstCikanUK.BackColor = Color.LightGreen;
                        zKat.Insert(cikanArabaUK);
                        break;

                    case "bodrumkat":
                        Araba cikanArabaBK = bKat.Pop();
                        lstCikanBK.Items.Add(cikanArabaBK.ad);
                        lstCikanBK.BackColor = Color.LightGreen;
                        zKat.Insert(cikanArabaBK);
                        break;

                    default:
                        break;
                }
            }

            else
            {
                lstZeminKat.BackColor = Color.Red;
                btnCikar.Enabled = false;
                btnEkle.Enabled = true;
            }

            ArabalariListele();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            btnHesapla.Enabled = false;

            double islemSayisi;
            double islemSuresi;
            islemSuresi = zKat.ArabaCikisSuresi();
            islemSayisi = 5 / islemSuresi;
            islemSayisi = Math.Round(islemSayisi, 2);

            txtHesaplanan.Text = "Bilgisayarın 5 saniyede çözebileceği otopark problemi sayısı: \r\n" + islemSayisi;
        }
     
        private void IlgiliNesneleriUret()
        {
            uKat = new Kat_Ust();
            zKat = new Kat_Zemin(15);
            bKat = new Kat_Bodrum(15);
        }

        private string KatlariKontrolEt(string cikacakKat)
        {
            if (uKat.size == 0)
            {
                cikacakKat = "bodrumkat";
                lstUstKat.BackColor = Color.Red;
                lstCikanUK.BackColor = Color.Red;
            }

            if (bKat.IsEmpty())
            {
                cikacakKat = "ustkat";
                lstBodrumKat.BackColor = Color.Red;
                lstCikanBK.BackColor = Color.Red;
            }

            if (uKat.size == 0 && bKat.IsEmpty())
                cikacakKat = "zeminkat";

            return cikacakKat;
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
                            yeniAraba.ad = "UKat - " + renkler[renk];  // Üst Kat için -> UKat-Yeşil...
                            uKat.InsertLast(yeniAraba);
                            break;

                        case 0:
                            yeniAraba = new Araba();
                            yeniAraba.ad = "ZKat - " + renkler[renk];  // Zemin Kat için -> ZKat-Yeşil...
                            zKat.Insert(yeniAraba);
                            break;

                        default:
                            yeniAraba = new Araba();
                            yeniAraba.ad = "BKat - " + renkler[renk]; // Bodrum Kat için -> BKat-Yeşil...
                            bKat.Push(yeniAraba);
                            break;
                    }
                }
            }
        }

        private void ArabalariListele()
        {
            uKat.ArabalariListele(lstUstKat);
            zKat.ArabalariListele(lstZeminKat);
            bKat.ArabalariListele(lstBodrumKat);
        }

        private void ListeTemizle()
        {
            lstCikanUK.Items.Clear();
            lstCikanZK.Items.Clear();
            lstCikanBK.Items.Clear();
            txtHesaplanan.Clear();

            lstCikanUK.BackColor = Color.White;
            lstCikanBK.BackColor = Color.White;
        }

        private void Liste_VarsayilanRenkler()
        {
            lstUstKat.BackColor = Color.White;
            lstZeminKat.BackColor = Color.White;
            lstBodrumKat.BackColor = Color.White;
            lstCikanUK.BackColor = Color.White;
            lstCikanBK.BackColor = Color.White;
            lstCikanZK.Items.Clear();
            txtHesaplanan.Clear();
        }

    }
}
