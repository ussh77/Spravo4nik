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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

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
                /*client.Send(mess); // отправка пользователю

                mess.To.Remove(mess.To[0]);
                mess.To.Add(from); //для сообщения на свой адрес
                mess.Subject = "Отправлено сообщение";*/
             
                client.Send(mess); // отправка себе
                mess.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = "228"; //имя пользователя
            string adressTo = "9041849542ss@gmail.com"; //адрес пользователя
            string messageSubject = textBox1.Text; //тема
            string messageText = textBox2.Text;  //текст
            SendMessage(userName, adressTo, messageSubject, messageText);
            MessageBox.Show("Письмо отправлено!");
        }
    }
}
