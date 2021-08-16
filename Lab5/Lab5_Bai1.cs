using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Nhom5
{
    public partial class Lab5_Bai1 : Form
    {
        public Lab5_Bai1()
        {
            InitializeComponent();
        }

        private bool checkAccounts()
        {
            string strFrom = txtBoxFrom.Text.Trim();
            string strTo = txtBoxTo.Text.Trim();
            //create regular express to find a char is NOT allow to contain in email(Ex: #$%..)
            Regex RgxEmail = new Regex("[^a-zA-Z0-9@._-]");
            if (string.IsNullOrEmpty(strFrom) || string.IsNullOrEmpty(strTo) || string.IsNullOrEmpty(txtBoxPass.Text.Trim()))
            {
                MessageBox.Show("Did not filled in the sending or receiving account information. Type again");
                return false;
            }
            else if (!strFrom.Contains('@') || !strTo.Contains('@') || RgxEmail.IsMatch(strFrom) || RgxEmail.IsMatch(strTo))
            {
                MessageBox.Show("The sending or receiving account information is wrong. Type again.");
                return false;
            }
            return true;
        }

        private void send_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = txtBoxFrom.Text.ToString().Trim();
                string mailto = txtBoxTo.Text.ToString().Trim();
                string password = txtBoxPass.Text.ToString().Trim();
                string aliasSender = txtBoxFromAlias.Text.ToString().Trim();
                string aliasRecipient = txtBoxToAlias.Text.ToString().Trim();
                if (checkAccounts())
                {
                    var basicCredential = new NetworkCredential(mailfrom, password);

                    using (MailMessage message = new MailMessage())
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;

                        MailAddress fromAddress = new MailAddress(mailfrom, aliasSender,System.Text.Encoding.UTF8);
                        MailAddress toAddress = new MailAddress(mailto, aliasRecipient, System.Text.Encoding.UTF8);
                        message.From = fromAddress;
                        message.Subject = txtBoxSubj.Text.ToString().Trim();
                        message.SubjectEncoding = System.Text.Encoding.UTF8;

                        // Set IsBodyHtml to true means you can send HTML email.
                        message.IsBodyHtml = true;
                        message.Body = txtBoxBody.Text.ToString();
                        message.BodyEncoding = System.Text.Encoding.UTF8;
                        message.To.Add(toAddress);
                        try
                        {
                            smtpClient.Send(message);
                            MessageBox.Show("Message sent");
                        }
                        catch
                        {
                            MessageBox.Show("Sending mail error. Try again");
                        }
                    }
                }
            }
        }

        private void checkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                txtBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPass.UseSystemPasswordChar = true;
            }
        }
    }
}
