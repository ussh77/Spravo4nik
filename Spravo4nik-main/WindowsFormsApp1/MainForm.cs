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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = comboBox1.Text == "8";
            label3.Visible = comboBox1.Text == "8";
            label4.Visible = comboBox1.Text == "8";

        }

        private void label4_Click(object sender, EventArgs e)
        {

            Form3 f = new Form3();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e )
        {
            ThemeForm f = new ThemeForm("Теорема Пифагора");
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ThemeForm f = new ThemeForm("Дробные выражения");
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}