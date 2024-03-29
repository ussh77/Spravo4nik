﻿using System;
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
    public partial class AddTheme : Form
    {
        public AddTheme()
        {
            InitializeComponent();
            ApplyTheme();
        }
        void ApplyTheme()
        {
            if (MainForm.IsDarkTheme)
            {
                button1.BackColor = Color.FromArgb(45, 45, 48);
                button3.BackColor = Color.FromArgb(45, 45, 48);
                checkButton.BackColor = Color.FromArgb(45, 45, 48);
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                button1.BackColor = Color.FromArgb(255, 255, 255);
                button3.BackColor = Color.FromArgb(255, 255, 255);
                checkButton.BackColor = Color.FromArgb(255, 255, 255);
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);


            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }


        string address = "";
        private void SaveClick(object sender, EventArgs e)
        {


            if (textBox1.Text != "" && classs.Text != "" && textBox3.Text != "" && linkfull.Text.Length > 8 && address != "")
            {
                File.AppendAllText("../../../Предметы.txt",
                    Environment.NewLine +
                    textBox1.Text + "; " + classs.Text + "; " + textBox3.Text + "; " + linkfull.Text);

                if (!address.Contains("Pictures"))
                    File.Copy(address, "../../../Pictures/" + textBox1.Text + ".png");

                MessageBox.Show("Добавлено!");
                textBox1.Text = "";
                classs.Text = "";
                textBox3.Text = "";
                linkfull.Text = "";
                address = "";
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Не заполнены все поля");
            }
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkfull.Text);
        }

    }
}
