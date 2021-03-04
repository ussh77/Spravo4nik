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

        public Theme(string _theme, string _schoolClass, string _tags)
        {
            theme = _theme;
            schoolClass = _schoolClass;
            tags = _tags;
            label = new Label();
            picture = new PictureBox();
        }
    }
    public partial class AllThemes : Form
    {
        //Theme[] themes_list = new Theme[20];
        public static List<Theme> themes_list = new List<Theme>();
        public AllThemes()
        {
            InitializeComponent();
            themes_list.Add(new Theme("Дробные выражения", "8", "Уравнения, Алгебра"));
            themes_list.Add(new Theme("Квадратные уравнения", "8", "Дробные, Алгебра, Выражения"));
            themes_list.Add(new Theme("Теорема Пифагора", "8", "Теорема, Геометрия, Пифагора, Теорема Пифагора"));
            themes_list.Add(new Theme("Теорема Виета", "8", "Теорема, Геометрия, Виета, Теорема Виета"));
            themes_list.Add(new Theme("Иррациональные уравнения", "8", "Иррациональные уравнения, Алгебра, Виета, уравнения"));
            themes_list.Add(new Theme("Числовые и алгебраические уравнения", "7", "Уравнения, Алгебра, Числовые"));
            themes_list.Add(new Theme("Линейное уравнение", "7", "Линейное, Алгебра, Уравнение"));
            themes_list.Add(new Theme("Системы двух линейных уравнений с двумя переменными", "7", "Системы, Алгебра, Линейных, Переменными"));
            themes_list.Add(new Theme("Понятие степени с натуральным показателем", "7", "Понятие, Степени, Показателем, Натуральным"));
            themes_list.Add(new Theme("Понятие многочлена", "7", "Понятие, Алгебра, Многочлена"));

            int y = 25;
            for (int i = 0; i < themes_list.Count; i++)
            {
                themes_list[i].label.Location = new Point(10, y);
                themes_list[i].label.Size = new Size(400, 25);
                themes_list[i].label.Text = themes_list[i].theme;
                themes_list[i].label.Font = new Font("Arial", 13);
                /*= new Label
                {   
                    Location = new Point(10, y),
                    Size = new Size(400, 25),
                    Text = themes_list[i].theme,
                    Font = new Font("Arial", 13),
                };*/

                themes_list[i].label.Click += new EventHandler(PrimerClick);
                panel1.Controls.Add(themes_list[i].label); 
                y = y + 30;              
            }    
        }

        private void AllThemes_Load(object sender, EventArgs e)
        {

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
