using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixItBtn_Click(object sender, EventArgs e)
        {
            if (redR1.Checked && redR2.Checked)
            {
                this.BackColor = Color.Red;
            } else if (redR1.Checked && yellowR2.Checked)
            {
                this.BackColor = Color.Orange;
            } else if (redR1.Checked && blueR2.Checked)
            {
                this.BackColor = Color.Purple;
            } else if (yellowR1.Checked && redR2.Checked)
            {
                this.BackColor = Color.Orange;
            } else if (yellowR1.Checked && yellowR2.Checked)
            {
                this.BackColor = Color.Yellow;
            } else if (yellowR1.Checked && blueR2.Checked)
            {
                this.BackColor = Color.Green;
            } else if (blueR1.Checked && redR2.Checked)
            {
                this.BackColor = Color.Purple;
            } else if (blueR1.Checked && yellowR2.Checked)
            {
                this.BackColor = Color.Green;
            } else if (blueR1.Checked && blueR2.Checked)
            {
                this.BackColor = Color.Blue;
            } else
            {
                MessageBox.Show("Select 1 color from each box to mix");
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
