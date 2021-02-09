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
    }
    public partial class AllThemes : Form
    {
        Theme[] themes_list = new Theme[20];
        public AllThemes()
        {
            InitializeComponent();
            themes_list[0].theme = "Квадратные уравнения";
            themes_list[0].label = label1;
            themes_list[1].theme = "Системы двух линейных уравнений с двумя переменными";
            themes_list[1].label = label2;
            themes_list[2].theme = "Линейное уравнение";
            themes_list[2].label = label3;
            for (int i = 0; i < 3; i++)
                themes_list[i].label.Text = themes_list[i].theme;
        }

        private void AllThemes_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           for(int i =0; i < 3; i++)
            {
                themes_list[i].label.Visible = true;
                if (!themes_list[i].theme.Contains(textBox1.Text))
                    themes_list[i].label.Visible = false;
            }
        }
    }
}
