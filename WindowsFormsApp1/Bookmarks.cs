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
    public partial class Bookmarks : Form
    {
        public Bookmarks()

        {

            InitializeComponent();
            int y = 25;
            for (int i = 0; i < AllThemes.zakladki.Count; i++)
            {
                AllThemes.zakladki[i].label.Location = new Point(10, y);
                AllThemes.zakladki[i].label.Size = new Size(400, 25);
                AllThemes.zakladki[i].label.Text = AllThemes.zakladki[i].theme;
                AllThemes.zakladki[i].label.Font = new Font("Arial", 13);
                AllThemes.zakladki[i].label.Click += new EventHandler(AllThemes.PrimerClick);
                panel1.Controls.Add(AllThemes.zakladki[i].label);
                y = y + 30;
            }
            //AllThemes.zakladki[0].label;
        }

        private void Bookmarks_Load(object sender, EventArgs e)
        {

        }
    }
}
