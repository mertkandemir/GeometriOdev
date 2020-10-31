using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometriOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSekil.Items.Add("--- Seçiniz ---");
            cbSekil.Items.Add("Kare");
            cbSekil.Items.Add("Dikdörtgen");
            cbSekil.Items.Add("Dik Üçgen");
            cbSekil.Items.Add("Eşkenar Üçgen");
            cbSekil.Items.Add("Daire");
            cbSekil.SelectedIndex = 0;
            pKare.Visible = false;
            pDikdörtgen.Visible = false;
            pDikUcgen.Visible = false;
            pEskenarUcgen.Visible = false;
            pDaire.Visible = false;

            Point point = new Point();
            point.X = 31;
            point.Y = 73;
            pKare.Location = point;
            pDikdörtgen.Location = point;
            pDikUcgen.Location = point;
            pEskenarUcgen.Location = point;
            pDaire.Location = point;

        }

        private void cbSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            pKare.Visible = false;
            pDikdörtgen.Visible = false;
            pDikUcgen.Visible = false;
            pEskenarUcgen.Visible = false;
            pDaire.Visible = false;
            if (cbSekil.SelectedIndex == 1)
            {
                pKare.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 2)
            {
                pDikdörtgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 3)
            {
                pDikUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 4)
            {
                pEskenarUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 5)
            {
                pDaire.Visible = true;
            }
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            if (cbSekil.SelectedIndex != 0 && cbHesapla.SelectedIndex != 0)
            {
                if (cbSekil.SelectedIndex == 1) // Kare
                {
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        Kare kare = new Kare();
                        kare.UzunKenar = Convert.ToDouble(tbKareKenar.Text, new CultureInfo("Tr"));
                        sonuc = kare.CevreHesapla();
                        lbSonuc.Items.Add(("Kare'nin Çevresi: ") + (sonuc));
                    }
                    else
                    {
                        Kare kare = new Kare(); // Alan
                        kare.UzunKenar = Convert.ToDouble(tbKareKenar.Text, new CultureInfo("Tr"));
                        sonuc = kare.AlanHesapla();
                        lbSonuc.Items.Add(("Kare'nin Alanı: ") + (sonuc));
                    }
                }

                if (cbSekil.SelectedIndex == 2) // Dikdörtgen
                {
                    if (cbHesapla.SelectedIndex == 1)  // Çevre
                    {
                        Dikdortgen dikdortgen = new Dikdortgen();
                        dikdortgen.UzunKenar = Convert.ToDouble(tbDikdortgenUzunKenar.Text, new CultureInfo("Tr"));
                        dikdortgen.KisaKenar = Convert.ToDouble(tbDikdortgenKisaKenar.Text, new CultureInfo("Tr"));
                        sonuc = dikdortgen.CevreHesapla();
                        lbSonuc.Items.Add(("Dikdörtgen'in Çevresi: ") + (sonuc));
                    }
                    else
                    {
                        Dikdortgen dikdortgen = new Dikdortgen(); // Alan
                        dikdortgen.UzunKenar = Convert.ToDouble(tbDikdortgenUzunKenar.Text, new CultureInfo("Tr"));
                        dikdortgen.KisaKenar = Convert.ToDouble(tbDikdortgenKisaKenar.Text, new CultureInfo("Tr"));
                        sonuc = dikdortgen.AlanHesapla();
                        lbSonuc.Items.Add(("Dikdörtgen'in Alanı: ") + (sonuc));
                    }
                }

                if (cbSekil.SelectedIndex == 3) // Dik Üçgen
                {
                    if (cbHesapla.SelectedIndex == 1) //Çevre
                    {
                        DikUcgen dikUcgen = new DikUcgen();
                        dikUcgen.TabanKenar = Convert.ToDouble(tbDikUcgenTabanKenar.Text, new CultureInfo("Tr"));
                        dikUcgen.Yukseklik = Convert.ToDouble(tbDikUcgenYukseklik.Text, new CultureInfo("Tr"));
                        sonuc = dikUcgen.CevreHesapla();
                        lbSonuc.Items.Add(("Dik Üçgen'in Çevresi: ") + (sonuc));
                    }
                    else
                    {
                        DikUcgen dikUcgen = new DikUcgen(); // Alan
                        dikUcgen.TabanKenar = Convert.ToDouble(tbDikUcgenTabanKenar.Text, new CultureInfo("Tr"));
                        dikUcgen.Yukseklik = Convert.ToDouble(tbDikUcgenYukseklik.Text, new CultureInfo("Tr"));
                        sonuc = dikUcgen.AlanHesapla();
                        lbSonuc.Items.Add(("Dik Üçgen'in Alanı: ") + (sonuc));
                    }
                }

                if (cbSekil.SelectedIndex == 4) // EşKenar Üçgen
                {
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        EskanarUcgen eskanarUcgen = new EskanarUcgen();
                        eskanarUcgen.TabanKenar = Convert.ToDouble(tbEskenarUcgenTabanKenar.Text, new CultureInfo("Tr"));
                        sonuc = eskanarUcgen.CevreHesapla();
                        lbSonuc.Items.Add(("Eşkenar Üçgen'in Çevresi: ") + (sonuc));
                    }
                    else
                    {
                        EskanarUcgen eskanarUcgen = new EskanarUcgen(); // Alan
                        eskanarUcgen.TabanKenar = Convert.ToDouble(tbEskenarUcgenTabanKenar.Text, new CultureInfo("Tr"));
                        sonuc = eskanarUcgen.AlanHesapla();
                        lbSonuc.Items.Add(("Eşkenar Üçgen'in Alanı: ") + (sonuc));
                    }
                }

                if (cbSekil.SelectedIndex == 5) // Daire
                {
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        Daire daire = new Daire();
                        daire.YariCap = Convert.ToDouble(tbDaire.Text, new CultureInfo("Tr"));
                        sonuc = daire.CevreHesapla();
                        lbSonuc.Items.Add(("Daire'nin Çevresi: ") + (sonuc));
                    }
                    else
                    {
                        Daire daire = new Daire(); // Alan
                        daire.YariCap = Convert.ToDouble(tbDaire.Text, new CultureInfo("Tr"));
                        sonuc = daire.AlanHesapla();
                        lbSonuc.Items.Add(("Daire'nin Alanı: ") + (sonuc));
                    }
                }
            }

        }

        private void btTemizle_Click(object sender, EventArgs e)
        {
            lbSonuc.Items.Clear();
        }
    }
}
