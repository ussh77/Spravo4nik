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
                Label label = new Label();
               label.Location = new Point(10, y);
                label.Size = new Size(400, 25);
               label.Text = AllThemes.zakladki[i].theme;
                label.Font = new Font("Arial", 13);
                label.Click += new EventHandler(AllThemes.PrimerClick);
                panel1.Controls.Add(label);
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
