using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public static bool IsDarkTheme = false;
        public MainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            IsDarkTheme = Properties.Settings.Default.IsDarkTheme;
            ApplyTheme();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(button6);
            int y = 25;
            for (int i = 0; i < AllThemes.themes_list.Count; i++)
            {
                //Если класс совпал
                if (AllThemes.themes_list[i].schoolClass == comboBox1.Text)
                {
                    var label = new Label();
                    label.Location = new Point(10, y);
                    label.Size = new Size(panel1.Width - 40, 45);
                    label.Text = AllThemes.themes_list[i].theme;
                    label.Font = new Font("Arial", 13);
                    label.Click += new EventHandler(AllThemes.PrimerClick);
                    panel1.Controls.Add(label);
                    y = y + 50;
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            AllThemes allThemes = new AllThemes();
            allThemes.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IsDarkTheme = !IsDarkTheme;
            ApplyTheme();
        }
        void ApplyTheme()
        {
            if (IsDarkTheme)
            {
                button1.BackColor = Color.FromArgb(45, 45, 48);
                button2.BackColor = Color.FromArgb(45, 45, 48);
                button3.BackColor = Color.FromArgb(45, 45, 48);
                button4.BackColor = Color.FromArgb(45, 45, 48);
                button5.BackColor = Color.FromArgb(45, 45, 48);
                button6.BackColor = Color.FromArgb(45, 45, 48);
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.FromArgb(255, 255, 255);
                button1.Text = "Светлая тема";
            }
            else
            {
                button1.BackColor = Color.FromArgb(255, 255, 255);
                button2.BackColor = Color.FromArgb(255, 255, 255);
                button3.BackColor = Color.FromArgb(255, 255, 255);
                button4.BackColor = Color.FromArgb(255, 255, 255);
                button5.BackColor = Color.FromArgb(255, 255, 255);
                button6.BackColor = Color.FromArgb(255, 255, 255);
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);
                button1.Text = "Темная тема";

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Bookmarks bookmarks = new Bookmarks();
            bookmarks.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "6")
            {
                try
                {

                    System.Diagnostics.Process.Start("chrome", "file://../../../matematika-6-klass-muravin-g_k_-muravina-o_v_-2014.pdf");//открывается без названия папки проекта и поэтому неработает
                }
                catch (Exception e1) {
                    string s = e1.Message;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            System.Diagnostics.Process.Start("https://qiwi.com/payment/form/99999?extra[%27accountType%27]=nickname&extra%5B%27account%27%5D=WALKO150"); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AddTheme().ShowDialog();
            AllThemes.FillThemes();
            comboBox1_SelectedIndexChanged(sender, e);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }
    }
}