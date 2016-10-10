using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        int bulan;
        public Form1()
        {
            InitializeComponent();

            DateTime awalTahun = new DateTime(2016, 1, 1);
            for (int i = awalTahun.DayOfYear; i <= awalTahun.DayOfYear; i++)
            {
                if (awalTahun.DayOfWeek.ToString() == "Sunday" || awalTahun.DayOfWeek.ToString() == "Monday")
                {
                    monthCalendar1.AddBoldedDate(awalTahun);
                }
                awalTahun = awalTahun.AddDays(1);
            }
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1996, 8, 1));
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "Januari" || domainUpDown1.Text == "Maret" || domainUpDown1.Text == "Mei" || domainUpDown1.Text == "Juli" || domainUpDown1.Text == "Agustus" || domainUpDown1.Text == "Oktober" || domainUpDown1.Text == "Desember")
            {
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = 31;
            }

            else if (domainUpDown1.Text == "Februari")
            {
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = 29;
            }

            else if (domainUpDown1.Text == "April" || domainUpDown1.Text == "Juni" || domainUpDown1.Text == "September" || domainUpDown1.Text == "November")
            {
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = 30;
            }

            else if (domainUpDown1.Text == "")
            {
                domainUpDown1.ResetText();
            }

            else
            {
                MessageBox.Show("Dilarang mengubah format yang telah ada!");
                domainUpDown1.ResetText();
            }

            if (domainUpDown1.Text == "Januari")
            {
                bulan = 1;
            }
            else if (domainUpDown1.Text == "Februari")
            {
                bulan = 2;
            }
            else if (domainUpDown1.Text == "Maret")
            {
                bulan = 3;
            }
            else if (domainUpDown1.Text == "April")
            {
                bulan = 4;
            }
            else if (domainUpDown1.Text == "Mei")
            {
                bulan = 5;
            }
            else if (domainUpDown1.Text == "Juni")
            {
                bulan = 6;
            }
            else if (domainUpDown1.Text == "Juli")
            {
                bulan = 7;
            }
            else if (domainUpDown1.Text == "Agustus")
            {
                bulan = 8;
            }
            else if (domainUpDown1.Text == "September")
            {
                bulan = 9;
            }
            else if (domainUpDown1.Text == "Oktober")
            {
                bulan = 10;
            }
            else if (domainUpDown1.Text == "November")
            {
                bulan = 11;
            }
            else
            {
                bulan = 12;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "")
            {
                MessageBox.Show("Anda belum memilih tanggal dan bulan dengan benar !");

                monthCalendar1.UpdateBoldedDates();
            }

            else
            {
                monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, bulan, Convert.ToInt32(numericUpDown1.Value)));

                MessageBox.Show("Penambahan hari libur berhasil !");

                monthCalendar1.UpdateBoldedDates();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (DateTime pilih = monthCalendar1.SelectionRange.Start; pilih <= monthCalendar1.SelectionRange.End; pilih = pilih.AddDays(1))
            {
                if (pilih.Day == 1 && pilih.Month == 8)
                {
                    monthCalendar1.AddAnnuallyBoldedDate(pilih);
                    MessageBox.Show("Anda tidak bisa menghapus hari ulang tahun anda !");
                }

                else
                {
                    monthCalendar1.RemoveAnnuallyBoldedDate(pilih);
                    MessageBox.Show("Penghapusan berhasil !");
                }

                monthCalendar1.UpdateBoldedDates();
            }
        }
    }
}
