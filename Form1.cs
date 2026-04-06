using System;
using System.Linq;
using System.Windows.Forms;

namespace Food_Ordering_System
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            string enteredUsername = txt_usrName.Text.Trim();
            string enteredPassword = txt_psWord.Text.Trim();

            string correctUsername = "@carao";
            string correctPassword = "12345678";

            // Username validation
            if (string.IsNullOrEmpty(enteredUsername))
            {
                lbl_usrMessage.Text = "Please input your username.";
                return;
            }
            else if (!enteredUsername.Contains("@"))
            {
                lbl_usrMessage.Text = "Username must contain '@'.";
                return;
            }

            // Password validation
            if (string.IsNullOrEmpty(enteredPassword))
            {
                lbl_psMessage.Text = "Please input your password.";
                return;
            }
            else if (enteredPassword.Length < 8)
            {
                lbl_invPs.Text = "Password must be at least 8 characters.";
                return;
            }

            
            if (enteredUsername != correctUsername && enteredPassword == correctPassword)
            {
                lbl_invUsrnm.Text = "Invalid Username";
                return;
            }
            else if (enteredUsername == correctUsername && enteredPassword != correctPassword)
            {
                lbl_invPs.Text = "Invalid Password";
                return;
            }
            else if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                MessageBox.Show("Access Granted, Proceed to Ordering");
                frm_Menu form2 = new frm_Menu();
                form2.Show();
                this.Hide();
            }
            else
            {
              
                lbl_invUsrnm.Text = "Invalid Username";
                lbl_invPs.Text = "Invalid Password";
            }
        }

        private void lnklbl_abtUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canva.com/design/DAHDdD9w2fk/GkJ0zBDstg2ht-mp57DujA/edit?utm_content=DAHDdD9w2fk&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton");
        }
    }
}
