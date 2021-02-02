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
        string link = "https://google.ru";

        public ThemeForm(string theme)
        {
            InitializeComponent();

            Text = theme;

            pictureBox1.Load("../../../Картинки/" + theme + ".PNG");
            if (theme == "Линейное уравнение")
            {
                link = "https://www.yaklass.ru/p/algebra/7-klass/matematicheskii-iazyk-matematicheskaia-model-11008/lineinoe-uravnenie-s-odnoi-peremennoi-9113/re-06b230f6-a2a6-43c0-99c1-23f1abe01318";
            }
            if (theme == "Числовые и алгебраические выражения")
            
            {
                link = "https://www.yaklass.ru/p/algebra/7-klass/matematicheskii-iazyk-matematicheskaia-model-11008/chislovye-i-algebraicheskie-vyrazheniia-11967/re-42838965-88e5-4eb4-b2c7-9eb47fffe83e";
            }
            if (theme == "Системы двух линейных уравнений с двумя переменными")

            {
                link = "https://www.yaklass.ru/p/algebra/7-klass/sistemy-dvukh-lineinykh-uravnenii-s-dvumia-peremennymi-10998/osnovnye-poniatiia-12436/re-433ba2a5-1afe-43d3-b5ad-2775dcaa9156";
            }
            if (theme == "Квадратные уравнения")

            {
                link = "https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/formuly-kornei-kvadratnogo-uravneniia-9115/re-7fc77e6b-731f-49f6-a4f9-b47915b58517#:~:text=%D0%A2%D0%B5%D0%BE%D1%80%D0%B8%D1%8F%3A,%E2%89%A0%200%20%2C%20%D0%BD%D0%B0%D0%B7%D1%8B%D0%B2%D0%B0%D0%B5%D1%82%D1%81%D1%8F%20%D0%BA%D0%B2%D0%B0%D0%B4%D1%80%D0%B0%D1%82%D0%BD%D1%8B%D0%BC%20%D1%83%D1%80%D0%B0%D0%B2%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5%D0%BC";
            }
            if (theme == "Дробные выражения")

            {
                link = "https://www.yaklass.ru/p/algebra/8-klass/algebraicheskie-drobi-arifmeticheskie-operatcii-nad-algebraicheskimi-drobi_-9085/osnovnye-poniatiia-11009/re-b1c21db0-a52f-40a0-ad04-8276f5033291";
            }
            if (theme == "Теорема Пифагора")

            {
                link = "https://www.yaklass.ru/p/geometria/8-klass/ploshchadi-figur-9235/teorema-pifagora-9225/re-c8adcccc-87a7-47f4-ae00-4d42ac40b985";
            }
            


        }
            
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
    }
}
