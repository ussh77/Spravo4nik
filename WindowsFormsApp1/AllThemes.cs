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

    public struct Theme
    {
        public PictureBox picture;
        public Label label;
        public string theme;
        public string schoolClass;
        public string tags;
        public string link;
        public Theme(string _theme, string _schoolClass, string _tags, string _link)
        {
            theme = _theme;
            schoolClass = _schoolClass;
            tags = _tags;
            label = new Label();
            picture = new PictureBox();
            link = _link;

        }
    }
    public partial class AllThemes : Form
    {
        //Theme[] themes_list = new Theme[20];
        public static List<Theme> themes_list = new List<Theme>();
        public static List<Theme> zakladki = new List<Theme>();
        /// <summary>
        /// Заполнение всех тем
        /// </summary>
        public static void FillThemes()
        {
            themes_list.Add(new Theme("Дробные выражения", "8", "Уравнения, Алгебра", "https://www.yaklass.ru/p/algebra/8-klass/algebraicheskie-drobi-arifmeticheskie-operatcii-nad-algebraicheskimi-drobi_-9085/osnovnye-poniatiia-11009/re-b1c21db0-a52f-40a0-ad04-8276f5033291"));
            themes_list.Add(new Theme("Квадратные уравнения", "8", "Дробные, Алгебра, Выражения", "https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/formuly-kornei-kvadratnogo-uravneniia-9115/re-7fc77e6b-731f-49f6-a4f9-b47915b58517#:~:text=%D0%A2%D0%B5%D0%BE%D1%80%D0%B8%D1%8F%3A,%E2%89%A0%200%20%2C%20%D0%BD%D0%B0%D0%B7%D1%8B%D0%B2%D0%B0%D0%B5%D1%82%D1%81%D1%8F%20%D0%BA%D0%B2%D0%B0%D0%B4%D1%80%D0%B0%D1%82%D0%BD%D1%8B%D0%BC%20%D1%83%D1%80%D0%B0%D0%B2%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5%D0%BC"));
            themes_list.Add(new Theme("Теорема Пифагора", "8", "Теорема, Геометрия, Пифагора, Теорема Пифагора", "https://www.yaklass.ru/p/geometria/8-klass/ploshchadi-figur-9235/teorema-pifagora-9225/re-c8adcccc-87a7-47f4-ae00-4d42ac40b985"));
            themes_list.Add(new Theme("Теорема Виета", "8", "Теорема, Геометрия, Виета, Теорема Виета", "https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/teorema-vieta-9116/re-1b3fd56d-1f01-4596-9b25-f62857cda735https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/teorema-vieta-9116/re-1b3fd56d-1f01-4596-9b25-f62857cda735re-c8adcccc-87a7-47f4-ae00-4d42ac40b985"));
            themes_list.Add(new Theme("Иррациональные уравнения", "8", "Иррациональные уравнения, Алгебра, Виета, уравнения", "https://www.yaklass.ru/p/algebra/8-klass/kvadratnye-uravneniia-11021/irratcionalnye-uravneniia-9120/re-0d81b9ee-4cf3-437f-9eff-c2067fc46893"));
            themes_list.Add(new Theme("Числовые и алгебраические уравнения", "7", "Уравнения, Алгебра, Числовые", "https://www.yaklass.ru/p/algebra/7-klass/matematicheskii-iazyk-matematicheskaia-model-11008/chislovye-i-algebraicheskie-vyrazheniia-11967/re-42838965-88e5-4eb4-b2c7-9eb47fffe83e"));
            themes_list.Add(new Theme("Линейное уравнение", "7", "Линейное, Алгебра, Уравнение", "https://www.yaklass.ru/p/algebra/7-klass/matematicheskii-iazyk-matematicheskaia-model-11008/lineinoe-uravnenie-s-odnoi-peremennoi-9113/re-06b230f6-a2a6-43c0-99c1-23f1abe01318"));
            themes_list.Add(new Theme("Системы двух линейных уравнений с двумя переменными", "7", "Системы, Алгебра, Линейных, Переменными", "https://www.yaklass.ru/p/algebra/7-klass/sistemy-dvukh-lineinykh-uravnenii-s-dvumia-peremennymi-10998/osnovnye-poniatiia-12436/re-433ba2a5-1afe-43d3-b5ad-2775dcaa9156"));
            themes_list.Add(new Theme("Понятие степени с натуральным показателем", "7", "Понятие, Степени, Показателем, Натуральным", ""));
            themes_list.Add(new Theme("Понятие многочлена", "7", "Понятие, Алгебра, Многочлена", "https://www.yaklass.ru/p/algebra/7-klass/odnochleny-arifmeticheskie-operatcii-nad-odnochlenami-10482/poniatie-odnochlena-standartnyi-vid-odnochlena-11038/re-6e78c99c-d0a0-44b2-9d03-35446cae7f6a"));
            themes_list.Add(new Theme("Распределительный закон умножения.Умножение в столбик на однозначное число", "4", "Умножение, Столбик, Математика", "https://www.yaklass.ru/p/matematika/4-klass/umnozhenie-16993/umnozhenie-na-odnoznachnoe-chislo-raspredelitelnyi-zakon-umnozheniia-otno_-16994/re-ef875e00-0aeb-4ac0-8568-2d5358ee78d8"));
            themes_list.Add(new Theme("Умножение многозначного числа на однозначное в столбик", "4", "Умножение, Столбик, Математика", ""));

            

            for (int i = 0; i < themes_list.Count; i++)
                themes_list[i].label.Click += new EventHandler(PrimerClick);
        }
        public AllThemes()
        {
            InitializeComponent();
            
            for(int i = 0; i < themes_list.Count; i++)
            zakladki.Add(themes_list[0]);
            int y = 25;
           foreach(Theme tema in themes_list)
            {
                tema.label.Location = new Point(10, y);
                tema.label.Size = new Size(400, 25);
                tema.label.Text = tema.theme;
                tema.label.Font = new Font("Arial", 13);
                panel1.Controls.Add(tema.label); 
                y = y + 30;              
            }    
        }

        private void AllThemes_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// открыть тему с формой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void PrimerClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Text != "")
            {
                ThemeForm f = new ThemeForm(lbl.Text);
                f.Show();
            }
        }

        private void Search(object sender, EventArgs e)
        {   
            int y = 25;
            for (int i = 0; i < themes_list.Count; i++)
            {                
                themes_list[i].label.Visible = true;

                if (textBox1.Text != "" &&
                    !themes_list[i].theme.Contains(textBox1.Text))
                    themes_list[i].label.Visible = false;
                if (comboBox1.Text != "" &&
                    themes_list[i].schoolClass != comboBox1.Text)
                    themes_list[i].label.Visible = false;

                if (themes_list[i].label.Visible)
                {
                    themes_list[i].label.Location = new Point(10, y);
                    y = y + 30;
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void classLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
