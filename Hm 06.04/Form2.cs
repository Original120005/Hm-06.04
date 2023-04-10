using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hm06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void EndButton_Click(object sender, EventArgs e)
        {
            int point = 0;
            progressBar1.Value = 0;
            EndButton.Enabled = false;

            if (radioButton1.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (radioButton6.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (radioButton12.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (radioButton9.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }

            if (checkBox1.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (checkBox2.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (checkBox3.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (checkBox10.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (checkBox9.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }
            if (checkBox7.Checked)
            {
                point++;
                progressBar1.Value += 10;
            }

            MessageBox.Show($"Your score: {point}/10", "Score", MessageBoxButtons.OK);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}