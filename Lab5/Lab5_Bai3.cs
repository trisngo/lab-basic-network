using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab5_Nhom5
{
    public partial class Lab5_Bai3 : Form
    {
        public Lab5_Bai3()
        {
            InitializeComponent();
        }

        string[] filePath = new string[10];
        int index = 0;
        string[] fileName = new string[10];
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mailfrom = txtBoxFrom.Text.ToString().Trim();
            string mailto = txtBoxTo.Text.ToString().Trim();
            string password = txtBoxPass.Text.ToString().Trim();
            string subject = txtBoxSubj.Text.ToString().Trim();
            string body = txtBoxBody.Text.ToString().Trim();
            string aliasSender = txtBoxFromAlias.Text.ToString().Trim();
            string aliasRecipient = txtBoxToAlias.Text.ToString().Trim();
            if (checkAccounts())
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(mailfrom, password);

                    MailAddress fromAddress = new MailAddress(mailfrom, aliasSender, System.Text.Encoding.UTF8);
                    MailAddress toAddress = new MailAddress(mailto, aliasRecipient, System.Text.Encoding.UTF8);
                    using (MailMessage message = new MailMessage(fromAddress, toAddress))
                    {
                        message.SubjectEncoding = System.Text.Encoding.UTF8;
                        message.Subject = subject;
                        message.IsBodyHtml = true;
                        message.BodyEncoding = System.Text.Encoding.UTF8;
                        message.Body = body;
                        
                        for(int i = 0; i < filePath.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(filePath[i]))
                            {
                                System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
                                contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;
                                contentType.Name = fileName[i];

                                Attachment attachment;
                                attachment = new Attachment(filePath[i], contentType);
                                message.Attachments.Add(attachment);
                            }
                        }
                        try
                        {
                            client.Send(message);
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

        private void btnAttach_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                filePath[index] = ofd.FileName;
                fileName[index] = ofd.SafeFileName;
                lbAttach.Text += fileName[index];
                index++;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn file");
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
