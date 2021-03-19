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


            //AllThemes.themes_list;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
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
            /*
                label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

            if (comboBox1.Text == "4")
            {
                label2.Text = "Распределительный закон умножения.Умножение в столбик на однозначное число";
                label3.Text = "Умножение многозначного числа на однозначное в столбик";

            }

            if (comboBox1.Text == "5")
            {
                label2.Text = "Десятичная система счисления";
                label3.Text = "Числовые и буквенные выражения";

            }

            else if (comboBox1.Text == "6")
            {
                label2.Text = "Положительные и отрицательные числа";
                label3.Text = "Делители и кратные";

            }

            else if (comboBox1.Text == "7")
            {
                label3.Text = "Линейное уравнение";
                label4.Text = "Системы двух линейных уравнений с двумя переменными";
                label2.Text = "Числовые и алгебраические выражения";
                label5.Text = "Понятие степени с натуральным показателем";
                label6.Text = "Понятие многочлена";
                label7.Text = "Разложение многочлена на множители";
            }
            else if (comboBox1.Text == "8")
            {
                label2.Text = "Теорема Пифагора";
                label3.Text = "Дробные выражения";
                label4.Text = "Квадратные уравнения";
                label5.Text = "Теорема Виета";
                label6.Text = "Иррациональные уравнения";
                label7.Text = "Некоторые символы математического языка";
            }
            label2.Visible = (label2.Text != "");
            label3.Visible = (label3.Text != "");
            label4.Visible = (label4.Text != "");
            label5.Visible = (label5.Text != "");
            label6.Visible = (label6.Text != "");
            label7.Visible = (label7.Text != "");
            */
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AllThemes allThemes = new AllThemes();
            allThemes.Show();
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://qiwi.com/payment/form/99999?extra[%27accountType%27]=nickname&extra%5B%27account%27%5D=WALKO150"); 
        }
    }
}