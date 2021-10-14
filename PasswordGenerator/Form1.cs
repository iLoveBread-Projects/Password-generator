using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using Microsoft.VisualBasic;

namespace PasswordGenerator
{
    public partial class frmPassGen : Form
    {
        public frmPassGen()
        {
            InitializeComponent();
        }

        private static bool addUpperCase;
        private static bool addNumbers;
        private static bool addSymbols;
        private static string validChars;
        private static string pass;

        private void chbxUpper_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxUpper.Checked == true)
            {
                addUpperCase = true;
            }
            else if (chbxUpper.Checked == false)
            {
                addUpperCase = false;
            }
        }

        private void chbxNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxNumbers.Checked == true)
            {
                addNumbers = true;
            }
            else if (chbxNumbers.Checked == false)
            {
                addNumbers = false;
            }
        }

        private void chbxSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSpecial.Checked == true)
            {
                addSymbols = true;
            }
            else if (chbxSpecial.Checked == false)
            {
                addSymbols = false;
            }
        }

        private void frmPassGen_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        static string generatePassword(int length)
        {
            // Base string for the valid characters.
            validChars = "abcdefghijklmnopqrstuvwxyz";
            // Check what checkboxes are ticked and addd the belonging characters to the base string.
            if (addUpperCase == true)
            {
                validChars +="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (addNumbers == true)
            {
                validChars += "1234567890";
            }
            if (addSymbols == true)
            {
                validChars += "?!@#$%^&*";
            }

            // Generate the password using a randomizer that takes a random character from the validChars string.
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Password length.
                int length = Convert.ToInt32(cbxAmount.Text);

                // Generate the password string.
                pass = generatePassword(length);

                // Show password in application.
                txtPassword.Text = pass;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a password length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                // Copies the password to your clipboard and tells the user that it copied the password.
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Text copied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Gives a MessageBox that there is nothing to copy in the textbox.
                MessageBox.Show("There is nothing to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
