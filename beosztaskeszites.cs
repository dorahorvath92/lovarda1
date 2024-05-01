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

namespace lovarda1
{
    public partial class beosztaskeszites : Form
    {
        int month, year;
        public beosztaskeszites()
        {
            InitializeComponent();
        }

        private void beosztaskeszites_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            //Lets get the first day of the month


            DateTime StartOfTheMonth = new DateTime(year,month,1);

            //get the count of days of the month

            int days = DateTime.DaysInMonth(year,month);

            //convert the startofthemonth to integer

            int DayOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            //first create a blank usercontrol

            for (int i = 1; i < DayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days

            for (int i=1; i<=days;  i++) 
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            //clear container

            daycontainer.Controls.Clear();

            //decrement month to go to previous month
            month--;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime StartOfTheMonth = new DateTime(year, month, 1);

            //get the count of days of the month

            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer

            int DayOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            //first create a blank usercontrol

            for (int i = 1; i < DayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    

        private void btnnext_Click(object sender, EventArgs e)
        {

            //clear container

            daycontainer.Controls.Clear();
            
            //increment month to go to next month
            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime StartOfTheMonth = new DateTime(year, month, 1);

            //get the count of days of the month

            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer

            int DayOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            //first create a blank usercontrol

            for (int i = 1; i < DayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //lets create usercontrol for days

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
