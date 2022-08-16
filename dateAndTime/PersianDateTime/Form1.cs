using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PersianDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar persian = new PersianCalendar();
            string PersianDate = persian.GetYear(DateTime.Now) + "/" + persian.GetMonth(DateTime.Now) + "/" + persian.GetDayOfMonth(DateTime.Now);
            string PersianTime = persian.GetHour(DateTime.Now) + ":" + persian.GetMinute(DateTime.Now) + ":" + persian.GetSecond(DateTime.Now);
            lblDate.Text = PersianDate + "  " + PersianTime;

            switch (persian.GetDayOfMonth(DateTime.Now))
            {
                case 1:
                    lblDayDate.Text = "یکم";
                    break;
                case 2:
                    lblDayDate.Text = "دوم";
                    break;
                case 3:
                    lblDayDate.Text = "سوم";
                    break;
                case 4:
                    lblDayDate.Text = "چهارم";
                    break;
                case 5:
                    lblDayDate.Text = "پنجم";
                    break;
                case 6:
                    lblDayDate.Text = "ششم";
                    break;
                case 7:
                    lblDayDate.Text = "هفتم";
                    break;
                case 8:
                    lblDayDate.Text = "هشتم";
                    break;
                case 9:
                    lblDayDate.Text = "نهم";
                    break;
                case 10:
                    lblDayDate.Text = "دهم";
                    break;
                case 11:
                    lblDayDate.Text = "یازدهم";
                    break;
                case 12:
                    lblDayDate.Text = "دوازدهم";
                    break;
                case 13:
                    lblDayDate.Text = "سیزدهم";
                    break;
                case 14:
                    lblDayDate.Text = "جهاردهم";
                    break;
                case 15:
                    lblDayDate.Text = "پانزدهم";
                    break;
                case 16:
                    lblDayDate.Text = "شانزدهم";
                    break;
                case 17:
                    lblDayDate.Text = "هفدهم";
                    break;
                case 18:
                    lblDayDate.Text = "هجدهم";
                    break;
                case 19:
                    lblDayDate.Text = "نوزدهم";
                    break;
                case 20:
                    lblDayDate.Text = "بیستم";
                    break;
                case 21:
                    lblDayDate.Text = "بیست و یکم";
                    break;
                case 22:
                    lblDayDate.Text = "بیست و دوم";
                    break;
                case 23:
                    lblDayDate.Text = "بیست و سوم";
                    break;
                case 24:
                    lblDayDate.Text = "بیست و چهارم";
                    break;
                case 25:
                    lblDayDate.Text = "بیست و پنجم";
                    break;
                case 26:
                    lblDayDate.Text = "بیست و ششم";
                    break;
                case 27:
                    lblDayDate.Text = "بیست و هفتم";
                    break;
                case 28:
                    lblDayDate.Text = "بیست و هشتم";
                    break;
                case 29:
                    lblDayDate.Text = "بیست و نهم";
                    break;
                case 30:
                    lblDayDate.Text = "سیم";
                    break;
                case 31:
                    lblDayDate.Text = "سی و یکم";
                    break;
                default:
                    lblDayDate.Text = "یکم";
                    break;
            }
            switch (persian.GetMonth(DateTime.Now))
            {
                case 1:
                    lblMonthDate.Text = "فروردین";
                    break;
                case 2:
                    lblMonthDate.Text = "اردیبهشت";
                    break;
                case 3:
                    lblMonthDate.Text = "خرداد";
                    break;
                case 4:
                    lblMonthDate.Text = "تیر";
                    break;
                case 5:
                    lblMonthDate.Text = "مرداد";
                    break;
                case 6:
                    lblMonthDate.Text = "شهریور";
                    break;
                case 7:
                    lblMonthDate.Text = "مهر";
                    break;
                case 8:
                    lblMonthDate.Text = "آبان";
                    break;
                case 9:
                    lblMonthDate.Text = "آذر";
                    break;
                case 10:
                    lblMonthDate.Text = "دی";
                    break;
                case 11:
                    lblMonthDate.Text = "بهمن";
                    break;
                case 12:
                    lblMonthDate.Text = "اسفند";
                    break;
            }

            lblFullDate.Text = lblDayDate.Text + " " + lblMonthDate.Text;
        }
    }
}
