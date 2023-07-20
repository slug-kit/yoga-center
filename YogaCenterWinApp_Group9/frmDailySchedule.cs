using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YogaCenterWinApp_Group9
{
    public partial class frmDailySchedule : Form
    {
        int month, year;
        public frmDailySchedule()
        {
            InitializeComponent();
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void frmCalendar_Load_1(object sender, EventArgs e)
        {
            DisplayDay();
        }
        private void DisplayDay()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DateTime startMoth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(((DateTime)startMoth).DayOfWeek);

            for (int i = 0; i < dayofweek; i++)
            {
                UserControlForCalendar userControlForCalendar = new UserControlForCalendar();
                daycontanier.Controls.Add(userControlForCalendar);
            }
            for (int i = 0; i < days; i++)
            {
                UserControlCalendarfordays userControlCalendarfordays = new UserControlCalendarfordays();
                userControlCalendarfordays.days(i);
                daycontanier.Controls.Add(userControlCalendarfordays);

            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontanier.Controls.Clear();
            month++;
            DateTime startMoth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(((DateTime)startMoth).DayOfWeek);

            for (int i = 0; i < dayofweek; i++)
            {
                UserControlForCalendar userControlForCalendar = new UserControlForCalendar();
                daycontanier.Controls.Add(userControlForCalendar);
            }
            for (int i = 0; i < days; i++)
            {

                UserControlCalendarfordays userControlCalendarfordays = new UserControlCalendarfordays();
                userControlCalendarfordays.days(i);
                daycontanier.Controls.Add(userControlCalendarfordays);

            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontanier.Controls.Clear();
            month--;
            DateTime startMoth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(((DateTime)startMoth).DayOfWeek);

            for (int i = 0; i < dayofweek; i++)
            {
                UserControlForCalendar userControlForCalendar = new UserControlForCalendar();
                daycontanier.Controls.Add(userControlForCalendar);
            }
            for (int i = 0; i < days; i++)
            {

                UserControlCalendarfordays userControlCalendarfordays = new UserControlCalendarfordays();
                userControlCalendarfordays.days(i);
                daycontanier.Controls.Add(userControlCalendarfordays);

            }
        }
    }
    }

