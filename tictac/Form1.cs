using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictac
{
   
    public partial class Form1 : Form
    {
        bool t = true;//true=x false=o
        int t_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Ravi", "About");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (t)

                b.Text = "X";
            else
                b.Text = "O";
            t = !t;
            b.Enabled = false;
            t_count++;
            checkforwinner();
        }
        private void checkforwinner()
        {
            bool winner = false;
            if ((A1.Text == A2.Text && A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
           else if ((B1.Text == B2.Text && B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text && C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            if ((A1.Text == B1.Text && B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
           else if ((A2.Text == B2.Text && B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text && B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            if ((A1.Text == B2.Text && B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text && B2.Text == C1.Text) && (!C1.Enabled))
                winner = true;
            
            if (winner)
            {
                disabled();
                string win = "";
                if (t)
                {
                    win = "O";
                    owincount.Text = (Int32.Parse(owincount.Text) + 1).ToString();
                }
                else
                {
                    win = "X";
                    xwincount.Text = Int32.Parse(xwincount.Text + 1).ToString();
                    MessageBox.Show(win + "Wins!", "Well Done");
                }
            }
            else 
            {
                if (t_count == 9)
                {
                    drawcount.Text = Int32.Parse(drawcount.Text + 1).ToString();
                    MessageBox.Show("Draw!", "Try Again");
                }
            }
        }
        private void disabled()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                }
            }
            catch
            {

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t = true;
            t_count = 0;
           
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            catch
            {

            }
        }
            
        }

        private void buttonenter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (t)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void buttonleave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
               b.Text = "";
            }
        }

        private void resetCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            owincount.Text = "0";
            xwincount.Text = "0";
            drawcount.Text = "0";
        }
    }




}
