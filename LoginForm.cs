using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
          
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(txtUser.Text, txtPassw.Text))

            {


                MessageBox.Show("Welcome to Library");




                Library_main_UI library_UI = new Library_main_UI();

                library_UI.Tag = this;
                library_UI.Show(this);
                Hide();

            }
            else
            {
                MessageBox.Show("Password or User name not valid");
            }

        }

        private bool IsvalidUser(string userName, string password)

        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var q = from p in context.user_details

                    where p.user_name == txtUser.Text

                    && p.password == txtPassw.Text

                    select p;



            if (q.Any())

            {

                return true;

            }

            else

            {

                return false;

            }

        }

        private void txtPassw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassw_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

