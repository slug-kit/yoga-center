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
    public partial class UserControlCalendarfordays : UserControl
    {
        public UserControlCalendarfordays()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCalendarfordays_Load(object sender, EventArgs e)
        {

        }
       public void days(int numday)
        {
            txtdays.Text = numday+"";
        }
    }
}
