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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveClick(object sender, EventArgs e)
        {
            File.AppendAllText("../../../Предметы.txt",
                Environment.NewLine +
                themee.Text + "; "+ classs.Text + "; "+ taggs.Text + "; "+ linkfull.Text);

            MessageBox.Show("1");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
