﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            int val = 100;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = val;
            progressBar1.Step = 1;
            for (int i = 0; i < val; ++i)
            {
                progressBar1.PerformStep();
                label1.Text = "Value = " + progressBar1.Value.ToString();
                this.Update();
                Thread.Sleep(100);
            }
        }
    }
}
