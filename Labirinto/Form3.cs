﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            this.Hide();
            formulario1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            this.Hide();
            formulario1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 formulario5 = new Form5();
            this.Hide();
            formulario5.Show();
        }
    }
}
