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
    public partial class ThemeForm : Form
    {
        Theme currentTheme;
        string link = "https://google.ru";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!AllThemes.zakladki.Contains(currentTheme))
            {
                AllThemes.zakladki.Add(currentTheme);
                MessageBox.Show("Добавлено");
            }
        }
        public ThemeForm(string theme)
        {
            InitializeComponent();
            foreach(Theme tema in AllThemes.themes_list)
            {
                if(tema.theme == theme)
                {
                    currentTheme = tema;
                }
            }
            Text = theme;
            try
            {
                pictureBox1.Load("../../../Pictures/" + theme + ".PNG");
            }
            catch(Exception) { }
 
            
    
           
         
            if (theme == "Некторые символы математического языка")

            {
                link = " https://www.yaklass.ru/p/algebra/8-klass/deistvitelnye-chisla-9092/osnovnye-poniatiia-11990/re-53fddb53-eb42-403c-91bc-d2b77f8036e1";
            }
            if (theme == "Понятие степени с натуральным показателем")

            {
                link = " https://www.yaklass.ru/p/algebra/7-klass/stepen-s-naturalnym-pokazatelem-i-ee-svoistva-9095/chto-takoe-stepen-s-naturalnym-pokazatelem-9093/re-df5ae963-7390-44c8-8fd8-99b83378ee26";
            }
            if (theme == "Разложение многочлена на множители")
            {
                link = "https://www.yaklass.ru/p/algebra/7-klass/odnochleny-arifmeticheskie-operatcii-nad-odnochlenami-10482/poniatie-odnochlena-standartnyi-vid-odnochlena-11038/re-6e78c99c-d0a0-44b2-9d03-35446cae7f6ahttps://www.yaklass.ru/p/algebra/7-klass/razlozhenie-mnogochlena-na-mnozhiteli-11005/chto-takoe-razlozhenie-na-mnozhiteli-11533/re-e7779a57-d403-4730-8cd4-86836fc9de8f";
            }
            if (theme == "Делители и кратные")
            {
                link = "https://www.yaklass.ru/p/matematika/6-klass/naturalnye-chisla-13968/delimost-naturalnykh-chisel-13854/re-a1c1280c-3929-4f31-8032-c750b616d268";
            }
            if (theme == "Положительные и отрицательные числа")
            {
                link = "https://www.yaklass.ru/p/matematika/6-klass/ratcionalnye-chisla-13871/polozhitelnye-i-otritcatelnye-chisla-koordinatnaia-priamaia-13769/re-d70678cc-8774-458c-abc7-bedd7791fcf1";
            }
            if (theme == "Десятичная система счисления")
            {
                link = "https://www.yaklass.ru/p/matematika/5-klass/naturalnye-chisla-13442/desiatichnaia-sistema-schisleniia-rimskaia-numeratciia-13051/re-0af75638-6fc0-432e-b119-1cc2255f14d2";
            }
            if (theme == "Числовые и буквенные выражения")
            {
                link = "https://www.yaklass.ru/p/matematika/5-klass/naturalnye-chisla-13442/chislovye-i-bukvennye-vyrazheniia-13345/re-435a3313-7e50-4abd-a4b6-44eb3c8586ed";
            }
            if (theme == "Умножение многозначного числа на однозначное в столбик")
            {
                link = "https://www.yaklass.ru/p/matematika/4-klass/umnozhenie-16993/umnozhenie-na-odnoznachnoe-chislo-raspredelitelnyi-zakon-umnozheniia-otno_-16994/re-e3701101-46a9-4151-968b-dba5b9f990cf";
            }
          

            }
            
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   if(!AllThemes.zakladki.Contains(currentTheme))
            MessageBox.Show("Добавлено");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
    }
}
