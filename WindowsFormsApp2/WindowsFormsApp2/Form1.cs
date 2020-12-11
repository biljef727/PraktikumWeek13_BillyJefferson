using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (lblAnswer.Text == "[EMPTY]")
            {
                lblAnswer.Text = textInput.Text;
            }
            if (lblAnswer.Text != "[EMPTY]" && textInput.Text == "DELETE")
            {
                lblAnswer.Text = "[EMPTY]";
            }
            if (lblAnswer.Text != "[EMPTY]" && textInput.Text == "HIDE")
            {
                lblAnswer.Hide();
            }
            if (lblAnswer.Text != "[EMPTY]" && textInput.Text == "SHOWN")
            {
                lblAnswer.Visible = true;
            }
            if (lblAnswer.Text != "[EMPTY]" && textInput.Text == "RED")
            {
                lblAnswer.ForeColor = Color.Red;
            }
            if (lblAnswer.Text != "[EMPTY]" && textInput.Text == "GREEN")
            {
                lblAnswer.ForeColor = Color.Green;
            }
            if (lblAnswer.Text != "[EMPTY]" && textInput.Text == "BLUE")
            {
                lblAnswer.ForeColor = Color.Blue;
            }
        }
    }
}
        
    
