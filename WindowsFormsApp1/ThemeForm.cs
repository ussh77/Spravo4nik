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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentTheme.link != "")
                System.Diagnostics.Process.Start(currentTheme.link);
            else
                MessageBox.Show("Эта тема слишком проста, чтобы искать ее продолжение");
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (!AllThemes.zakladki.Contains(currentTheme))
            {
                AllThemes.zakladki.Add(currentTheme);
                MessageBox.Show("Добавлено в закладки");
            }
        }
    }
}
