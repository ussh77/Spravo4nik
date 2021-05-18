using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bookmarks : Form
    {
        public Bookmarks()

        {

            InitializeComponent();
            int y = 25;
            for (int i = 0; i < AllThemes.zakladki.Count; i++)
            {
                UC1 theme = new UC1(AllThemes.zakladki[i]);
                theme.Location = new Point(10, y);
                panel1.Controls.Add(theme);
                y = y + 116;
            }

        }
        static void SendMessage(string userName, string adressTo, string messageSubject, string messageText)
        {
            try
            {
                string from = "9041849542sss@gmail.com"; // адреса отправителя
                string net = "UuQqN228"; // пaрoль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = messageSubject; // тема
                mess.Body = messageText; // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com"; //smtр-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], net);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                mess.IsBodyHtml = true;
                mess.Body = File.ReadAllText("../../../1.txt");

                foreach (Theme theme in AllThemes.zakladki)
                {
                    mess.Body +=
                    "<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  <a target=\"_blank\" rel=\"nofollow noopener\" href=\"" + theme.link + "\">" + theme.theme + "</a> </p>";
                }

                client.Send(mess); // отправка себе
                mess.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string userName = "228"; //имя пользователя
            string adressTo = "9041849542ss@gmail.com"; //адрес пользователя
            string messageSubject = "Отложенные темы"; //тема
            string messageText = File.ReadAllText("../../../1.txt");  //текст
            SendMessage(userName, adressTo, messageSubject, messageText);
            MessageBox.Show("Письмо отправлено!");

        }

     
    }
}
