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
                UC1 theme = new UC1(AllThemes.zakladki[i]);
                theme.Location = new Point(10, y);
                panel1.Controls.Add(theme);
                y = y + 30;
            }
            //AllThemes.zakladki[0].label;

        }

        private void Bookmarks_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
