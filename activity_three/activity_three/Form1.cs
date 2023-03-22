using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity_three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) 
        {
            othersLabel.Visible = false;
            othersTextBox.Visible = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string str = " ";
            //Japan CheckBox
            if (japanCheckBox.Checked == true) 
            {
                str = str + japanCheckBox.Text;
                str += " "; 
            }
            //Philippine Checkbox
            if (philippinesCheckBox.Checked == true)
            {
                str = str + philippinesCheckBox.Text;
                str += " ";
            }
            //Thailand Checkbox
            if (thailandCheckBox.Checked == true)
            {
                str = str + thailandCheckBox.Text;
                str += " ";
            }
            //Austrilia CheckBox
            if (austriliaCheckBox.Checked == true)
            {
                str = str + austriliaCheckBox.Text;
                str += " ";
            }
            //Others CheckBox
            if (othersCheckBox.Checked == true)
            {
                str = str + othersTextBox.Text;
                str += " ";
            }

            if (str != null) 
            {
                MessageBox.Show("You Selected : \n" + str + "\n Thank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void othersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (othersCheckBox.Checked == false)
            {
                othersLabel.Visible = false;
                othersTextBox.Visible = false;
            }
            else 
            {
                othersLabel.Visible = true;
                othersTextBox.Visible = true;
            
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
