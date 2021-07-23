using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthlyWorkTime
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            string Username = txt_UserName.Text; 
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            string password = txt_Password.Text;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           
        }
    }
}
