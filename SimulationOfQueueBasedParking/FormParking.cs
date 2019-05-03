using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationOfQueueBasedParking
{
    public partial class FormParking : Form
    {
        public FormParking()
        {
            InitializeComponent();
        }

        public static int carNumber;
        public static int parkingStatus; //1 otoparkın dolu olduğunu, 0 ise otoparkın boş olduğunu gösterir

        private void FormParking_Load(object sender, EventArgs e)
        {
            btnListele.Visible = false;
            btnOncelikliListele.Visible = false;
            label2.Visible = false;
            checkBoxKazanc.Visible = false;
            checkBoxSil.Visible = false;
            btnSil.Visible = false;
            btnOncelikliSil.Visible = false;
            btnKazancHesapla.Visible = false;
        }

        private void BtnOtoparkArabaEkle_Click(object sender, EventArgs e)
        {
            btnListele.Visible = true;
            btnOncelikliListele.Visible = true;
            label2.Visible = true;
            checkBoxKazanc.Visible = true;
            checkBoxSil.Visible = true;

            carNumber = Convert.ToInt32(txtArabaSayisi.Text);
            Parking parking = new Parking();
            parking.AddCarToParking();
            parking.AddToPriorityCar();

            btnOtoparkArabaEkle.Enabled = false;
            MessageBox.Show("Arabalar Otoparka Eklendi");
            parkingStatus = 1;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            carNumber = Convert.ToInt32(txtArabaSayisi.Text);
            Parking parking = new Parking();
            MessageBox.Show(parking.ListCarParking() + "Ortalama İşlem Süresi : " + parking.IslemSuresiOrtalamaHesapla());
        }

        private void BtnOncelikliListele_Click(object sender, EventArgs e)
        {
            carNumber = Convert.ToInt32(txtArabaSayisi.Text);
            Parking parking = new Parking();
            MessageBox.Show(parking.ListPriorityCar() + "Ortalama İşlem Süresi : " + parking.IslemSuresiOrtalamaHesapla());
        }

        private void CheckBoxKazanc_CheckedChanged(object sender, EventArgs e)
        {
            if (parkingStatus == 1)
            {
                if (checkBoxKazanc.Checked == true)
                {
                    checkBoxSil.Enabled = false;
                    btnKazancHesapla.Visible = true;
                }
                else
                {
                    checkBoxSil.Enabled = true;
                    btnKazancHesapla.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Arabalar Otoparktan Çıkarılmıştır. Otopark Boşaltılmadan Tekrar Deneyiniz.");
            }
        }

        private void CheckBoxSil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSil.Checked == true)
            {
                checkBoxKazanc.Enabled = false;
                btnSil.Visible = true;
                btnOncelikliSil.Visible = true;
            }
            else
            {
                checkBoxKazanc.Enabled = true;
                btnSil.Visible = false;
                btnOncelikliSil.Visible = false;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            carNumber = Convert.ToInt32(txtArabaSayisi.Text);
            Parking parking = new Parking();
            MessageBox.Show(parking.RemoveCarParking());

            parkingStatus = 0;
        }

        private void BtnOncelikliSil_Click(object sender, EventArgs e)
        {
            carNumber = Convert.ToInt32(txtArabaSayisi.Text);
            Parking parking = new Parking();
            MessageBox.Show(parking.OncelikliArabaSil());

            parkingStatus = 0;
        }

        private void BtnKazancHesapla_Click(object sender, EventArgs e)
        {
            Parking parking = new Parking();
            MessageBox.Show(parking.CalculateEarnings());
        }
    }
}
