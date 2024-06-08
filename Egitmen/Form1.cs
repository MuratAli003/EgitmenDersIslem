using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egitmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Egitmen> egitmenler = new List<Egitmen>();
        Ders Turkce = new Ders()
        {
            ID = 1,
            DersAdı = "Turkce",
        };
        Ders Matematik = new Ders()
        {
            ID = 2,
            DersAdı = "Matematik",
        };
        Ders biyoloji = new Ders()
        {
            ID = 3,
            DersAdı = "Biyoloji",
        };
        Ders Fizik = new Ders()
        {
            ID = 4,
            DersAdı = "Fizik",
        };
        Ders Kimya = new Ders()
        {
            ID = 5,
            DersAdı = "Kimya",
        };
        Ders Sosyal = new Ders()
        {
            ID = 6,
            DersAdı = "Sosyal",
        };

        List<Ders> dersler =new List<Ders>();
        private void DersleriListele()
        {
            dersler.Add(Turkce);
            dersler.Add(Matematik);
            dersler.Add (Sosyal);
            dersler.Add(Kimya);
            dersler.Add(Fizik);
            dersler.Add(biyoloji);

        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            dgwEgitmen.DataSource = null;
            List<Ders> list = new List<Ders>();
            DersKontrol(list);

            if (list.Count != 0)
            {
                if (!string.IsNullOrEmpty(tbxOlusturAd.Text))
                {
                    string ad = tbxOlusturAd.Text;
                    Egitmen egitmen = new Egitmen();
                    bool kontrol = true;

                    if (string.IsNullOrEmpty(tbxOlusturID.Text))
                    {
                        kontrol = false;
                        MessageBox.Show("ID Değeri Giriniz!");
                    }
                    else
                    {
                        for (int i = 0; i < tbxOlusturID.Text.Length; i++)
                        {
                            if (!char.IsDigit(tbxOlusturID.Text[i]))
                            {
                                kontrol = false;
                                MessageBox.Show("ID Hatalı!");
                                break;
                            }
                        }
                    }
                    if (kontrol)
                    {
                        int ID = Convert.ToInt32(tbxOlusturID.Text);
                        bool listeKontrol = true;

                        foreach (Egitmen egitmen1 in egitmenler)
                        {
                            if (egitmen1.ID == ID)
                            {
                                listeKontrol = false;
                                MessageBox.Show("Egitmen ID Mevcut");

                            }
                        }


                        if (listeKontrol)
                        {
                            egitmen.ID = ID;
                            egitmen.egitmen_adı = ad;
                            egitmen.verilen_dersler = new Ders[list.Count];


                            for (int i = 0; i < list.Count; i++)
                            {
                                list[i].EgitmenID = ID;
                                egitmen.verilen_dersler[i] = list[i];

                            }


                            egitmenler.Add(egitmen);
                            cbxEgitmen.Items.Add(egitmen.egitmen_adı);
                            cbxListele.Items.Add(egitmen.egitmen_adı);
                            dgwEgitmen.DataSource = egitmen.verilen_dersler.ToList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Eğitmen Adı Giriniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ders Seçiniz");
            }
        }

        private void DersKontrol(List<Ders> list)
        {
            if (chxTurkce.Checked)
            {
                list.Add(Turkce);
            }
            if (chxMat.Checked)
            {
                
                list.Add(Matematik);
            }
            if (chxBiyo.Checked)
            {

                list.Add(biyoloji);
            }
            if (chxFizik.Checked)
            {
                list.Add(Fizik);
            }
            if (chxKimya.Checked)
            {
                list.Add(Kimya);
            }
            if (chxSosyal.Checked)
            {
                list.Add(Sosyal);
            }
        }

        private void cbxEgitmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDers.Items.Clear();

            if (cbxEgitmen.SelectedItem != null)
            {
                string egitmenAd = cbxEgitmen.SelectedItem.ToString();
               

                foreach (Egitmen egitmen in egitmenler)
                {
                    if (egitmen.egitmen_adı.Equals(egitmenAd))
                    {

                        for (int i = 0; i < dersler.Count; i++)
                        {
                            bool dersKontrol = true;
                            for (int j = 0; j < egitmen.verilen_dersler.Length; j++)
                            {
                                if (egitmen.verilen_dersler[j] == dersler[i])
                                {
                                    dersKontrol = false;
                                }
                            }
                            if (dersKontrol)
                            {


                                cbxDers.Items.Add(dersler[i].DersAdı);
                            }
                        }

                    }
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cbxEgitmen.Text))
            {
                if(!string.IsNullOrEmpty(cbxDers.Text))
                {
                    foreach(Egitmen egitmen in egitmenler)
                    {
                        if (egitmen.egitmen_adı.Equals(cbxEgitmen.SelectedItem.ToString()))
                        {
                            Ders[] gecici = egitmen.verilen_dersler;

                            Ders[] yeni = new Ders[gecici.Length+1];

                            for (int i = 0; i < gecici.Length; i++)
                            {
                                yeni[i] = gecici[i];
                            }

                            foreach(Ders ders in dersler)
                            {
                                if (ders.DersAdı.Equals(cbxDers.SelectedItem.ToString()))
                                {
                                    yeni[yeni.Length - 1] = ders;
                                    yeni[yeni.Length - 1].EgitmenID = egitmen.ID;

                                }
                            }                     
                            cbxDers.Items.Remove(cbxDers.SelectedItem.ToString());
                            cbxDers.Text = "";

                            egitmen.verilen_dersler = yeni;
                            dgwEgitmen.DataSource = egitmen.verilen_dersler.ToList();
                            MessageBox.Show("Ders Başarıyla Eklendi");

                        }
                    }   
                }
                else
                {
                    MessageBox.Show("Lütfen Ders Seciniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eğitmen Seciniz");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cbxListele.Text))
            {
                foreach (Egitmen egitmen in egitmenler)
                {
                    if (egitmen.egitmen_adı.Equals(cbxListele.SelectedItem.ToString()))
                    {
                        dgwEgitmen.DataSource = egitmen.verilen_dersler.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eğitmen Seçiniz");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DersleriListele();
        }
    }
}
