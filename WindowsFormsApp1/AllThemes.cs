using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        /// 

        public static void FillThemes()
        {
            string[] products = File.ReadAllLines("../../../Предметы.txt");

            foreach (string product in products)
            {
                string[] parts = product.Split(new String[] { "; " }, StringSplitOptions.None);
                themes_list.Add(new Theme(parts[0], parts[1], parts[2], parts [3]));
            }
            

            for (int i = 0; i < themes_list.Count; i++)
                themes_list[i].label.Click += new EventHandler(PrimerClick);
        }

    public AllThemes()
        {
            InitializeComponent();
           ApplyTheme();
             
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
        void ApplyTheme()
        {
            if (MainForm.IsDarkTheme)
            {
                button1.BackColor = Color.FromArgb(45, 45, 48);
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                button1.BackColor = Color.FromArgb(255, 255, 255);
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);
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
