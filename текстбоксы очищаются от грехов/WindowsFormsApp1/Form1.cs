using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox1_MouseDown(object sender, MouseEventArgs e)
        {
            textbox1.Text = "TextBox 1";
        }

        private void textbox2_MouseDown(object sender, MouseEventArgs e)
        {
            textbox2.Text = "TextBox 2";
        }

        private void textbox3_MouseDown(object sender, MouseEventArgs e)
        {
            textbox3.Text = "TextBox 3";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
        }
    }
}
