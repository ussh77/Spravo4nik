﻿using System;
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
        public ThemeForm(string theme)
        {
            InitializeComponent();

            if (theme == "Теорема Пифагора")
            {
                pictureBox1.Load("../../../Картинки/теорпиф.PNG");
            }
            if (theme == "Дробные выражения")
            {
                pictureBox1.Load("../../../Картинки/дробные выр 1.PNG");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}