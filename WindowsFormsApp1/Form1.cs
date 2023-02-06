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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image image = Properties.Resources.baku;
            label1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(emailTxtb.Text);
        }

        public bool IsClicked { get; set; } = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!IsClicked)
            {
                textBox1.PasswordChar = '\0';
                pictureBox2.Image = Properties.Resources.close_;
            }
            else
            {
                textBox1.PasswordChar = '*';
                pictureBox2.Image = Properties.Resources.open;
            }
            IsClicked = !IsClicked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 5)
            {
                infoLbl.Text = "Weak password";
                infoLbl.ForeColor = Color.Red;
            }
        }
    }
}
