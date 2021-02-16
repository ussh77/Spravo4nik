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
        public MainForm()
        {
            InitializeComponent();
            
            comboBox1.SelectedIndex = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                //https://www.yaklass.ru/p/algebra/7-klass/matematicheskii-iazyk-matematicheskaia-model-11008/lineinoe-uravnenie-s-odnoi-peremennoi-9113/re-06b230f6-a2a6-43c0-99c1-23f1abe01318
                label2.Text = "Числовые и алгебраические выражения";
                //https://www.yaklass.ru/p/algebra/7-klass/matematicheskii-iazyk-matematicheskaia-model-11008/chislovye-i-algebraicheskie-vyrazheniia-11967/re-42838965-88e5-4eb4-b2c7-9eb47fffe83e
                label4.Text = "Системы двух линейных уравнений с двумя переменными";
                //
                label5.Text = "Понятие степени с натуральным показателем";
                //https://www.yaklass.ru/p/algebra/7-klass/stepen-s-naturalnym-pokazatelem-i-ee-svoistva-9095/chto-takoe-stepen-s-naturalnym-pokazatelem-9093/re-df5ae963-7390-44c8-8fd8-99b83378ee26
                label6.Text = "Понятие многочлена";
                
                label7.Text = "Разложение многочлена на множители";
            }

            else if (comboBox1.Text == "8")
            {
                label2.Text = "Теорема Пифагора";
                //https://www.yaklass.ru/p/geometria/8-klass/ploshchadi-figur-9235/teorema-pifagora-9225/re-c8adcccc-87a7-47f4-ae00-4d42ac40b985
                label3.Text = "Дробные выражения";
                //https://www.yaklass.ru/p/algebra/8-klass/algebraicheskie-drobi-arifmeticheskie-operatcii-nad-algebraicheskimi-drobi_-9085/osnovnye-poniatiia-11009/re-b1c21db0-a52f-40a0-ad04-8276f5033291
                label4.Text = "Квадратные уравнения";
                //https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/formuly-kornei-kvadratnogo-uravneniia-9115/re-7fc77e6b-731f-49f6-a4f9-b47915b58517#:~:text=%D0%A2%D0%B5%D0%BE%D1%80%D0%B8%D1%8F%3A,%E2%89%A0%200%20%2C%20%D0%BD%D0%B0%D0%B7%D1%8B%D0%B2%D0%B0%D0%B5%D1%82%D1%81%D1%8F%20%D0%BA%D0%B2%D0%B0%D0%B4%D1%80%D0%B0%D1%82%D0%BD%D1%8B%D0%BC%20%D1%83%D1%80%D0%B0%D0%B2%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5%D0%BC
                label5.Text = "Теорема Виета";
                //https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/teorema-vieta-9116/re-1b3fd56d-1f01-4596-9b25-f62857cda735
                label6.Text = "Иррациональные уравнения";
                //https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/irratcionalnye-uravneniia-9120/re-0d81b9ee-4cf3-437f-9eff-c2067fc46893
                label7.Text = "Некоторые символы математического языка";
                //https://www.yaklass.ru/p/algebra/8-klass/deistvitelnye-chisla-9092/osnovnye-poniatiia-11990/re-53fddb53-eb42-403c-91bc-d2b77f8036e1
                

            }

            label2.Visible = (label2.Text != "");
            label3.Visible = (label3.Text != "");
            label4.Visible = (label4.Text != "");
            label5.Visible = (label5.Text != "");
            label6.Visible = (label6.Text != "");
            label7.Visible = (label7.Text != "");
        }

        private void PrimerClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Text != "")
            {
                ThemeForm f = new ThemeForm(lbl.Text);
                f.Show();
            }
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
            if(button1.Text == "Темная тема")
            {
                button1.BackColor = Color.FromArgb(25, 25, 25);
                button2.BackColor = Color.FromArgb(25, 25, 25);
                BackColor = Color.FromArgb(25, 25, 25);
                ForeColor = Color.FromArgb(255, 255, 255);
                button1.Text = "Светлая тема";
            }
            else
            {
                button1.BackColor = Color.FromArgb(255, 255, 255);
                button2.BackColor = Color.FromArgb(255, 255, 255);
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);
                button1.Text = "Темная тема";
            }
        }
    }
}
