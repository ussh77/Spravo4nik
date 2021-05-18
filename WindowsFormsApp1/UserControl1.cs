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
    public partial class UC1 : UserControl
    {
        Theme theme1;
        public UC1(Theme theme)
        {
            theme1 = theme;
            InitializeComponent();
            label1.Text = theme.theme;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(theme1.link);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AllThemes.zakladki.Remove(theme1);
            this.Parent = null;
        }
    }
}
