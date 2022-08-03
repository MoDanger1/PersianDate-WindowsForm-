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
        }
    }
}
