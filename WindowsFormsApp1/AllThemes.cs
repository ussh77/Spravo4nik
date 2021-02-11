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
    }
    public partial class AllThemes : Form
    {
        Theme[] themes_list = new Theme[20];
        public AllThemes()
        {
            InitializeComponent();
            themes_list[0].theme = "Квадратные уравнения";
            themes_list[0].label = label1;
            themes_list[0].schoolClass = "8";
            themes_list[0].tags = "Уравнения, Алгебра";

            themes_list[1].theme = "Дробные выражения";
            themes_list[1].label = label2;
            themes_list[1].schoolClass = "8";
            themes_list[1].tags = "Дробные, Алгебра, Выражения";

            themes_list[2].theme = "Теорема Пифагора";
            themes_list[2].label = label3;
            themes_list[2].schoolClass = "8";
            themes_list[2].tags = "Теорема, Геометрия, Пифагора, Теорема Пифагора";

            themes_list[3].theme = "Теорема Виета";
            themes_list[3].label = label4;
            themes_list[3].schoolClass = "8";
            themes_list[3].tags = "Теорема, Геометрия, Виета, Теорема Виета";

            themes_list[4].theme = "Иррациональные уравнения";
            themes_list[4].label = label5;
            themes_list[4].schoolClass = "8";
            themes_list[4].tags = "Иррациональные уравнения, Алгебра, Виета, уравнения";
            //7
            themes_list[5].theme = "Числовые и алгебраические уравнения";
            themes_list[5].label = label6;
            themes_list[5].schoolClass = "7";
            themes_list[5].tags = "Уравнения, Алгебра, Числовые";

            themes_list[6].theme = "Линейное уравнение";
            themes_list[6].label = label7;
            themes_list[6].schoolClass = "7";
            themes_list[6].tags = "Линейное, Алгебра, Уравнение";

            themes_list[7].theme = "Системы двух линейных уравнений с двумя переменными";
            themes_list[7].label = label8;
            themes_list[7].schoolClass = "7";
            themes_list[7].tags = "Системы, Алгебра, Линейных, Переменными ";

            themes_list[8].theme = "Понятие степени с натуральным показателем";
            themes_list[8].label = label9;
            themes_list[8].schoolClass = "7";
            themes_list[8].tags = "Понятие, Степени, Показателем, Натуральным";

            themes_list[9].theme = "Понятие многочлена";
            themes_list[9].label = label10;
            themes_list[9].schoolClass = "7";
            themes_list[9].tags = "Понятие, Алгебра, Многочлена";

            for (int i = 0; i < 10; i++)
            {
                themes_list[i].label.Text = themes_list[i].theme;
                themes_list[i].label.Click += new EventHandler(PrimerClick);
                themes_list[i].label.Font = new Font("Arial", 13);
                themes_list[i].label.Location = new Point(10, 10  + 20 * i);
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
           for(int i =0; i < 10; i++)
            {
                themes_list[i].label.Visible = true;
                if (!themes_list[i].theme.Contains(textBox1.Text))
                    themes_list[i].label.Visible = false;
                if (comboBox1.Text != "" &&
                    themes_list[i].schoolClass != comboBox1.Text)
                    themes_list[i].label.Visible = false;
            }
        }
    }
}
