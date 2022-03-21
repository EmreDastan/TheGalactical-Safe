using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe
{
    public partial class Form1 : Form
    {
        /* Uncomment button_newpass_clicked method, add it to GUI
         * and fix the problem.
        Default password is "pass" variable and equals to 2854.
        */
        bool newpassclicked = false;
        bool unlocked = false;
        private int passinput;
        private int setcounter = 0;
        private string password = "";
        private int digitlimit = 4;
        private int count = 0;
        private int pass = 2854;
        private int trylimit = 6;
        private int trying = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "1";
                count++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "2";
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "3";
                count++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "4";
                count++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "5";
                count++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "6";
                count++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "7";
                count++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "8";
                count++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "9";
                count++;
            }
        }

        /*private void button_newpass_Click(object sender, EventArgs e)
        {
            newpassclicked = true;
            count = 0;
            password = "";
            Display.Text = "Current Pass :";

        }*/

        private void button_reset_Click(object sender, EventArgs e)
        {
            count = 0;
            password = "";
            Display.Text = "LOCKED";
            setcounter = 0;
            unlocked = false;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (count <= digitlimit)
            {
                password += "0";
                count++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!unlocked)
                {
                    passinput = Convert.ToInt32(password);
                    if (!newpassclicked && setcounter == 0)
                    {
                        if ((passinput == pass) && (count == digitlimit) && (trying < trylimit))
                        {
                            // True pass
                            Display.Text = "UNLOCKED";
                            unlocked = true;
                        }
                        if ((passinput != pass) && (count == digitlimit) && (trying < trylimit))
                        {
                            // Wrong pass
                            Display.Text = "WRONG PASS";
                            trying++;
                        }
                        if ((count != digitlimit) && (trying < trylimit))
                        {
                            // You can only enter 4 digits length password
                            Display.Text = "ONLY 4 DIGITS";
                            count = 0;
                        }
                        if (trying >= trylimit)
                        {
                            // Max amount of tries reached
                            Display.Text = "OUT OF TRIES";
                        }
                    }
                    else
                    {
                        setcounter++;
                        passinput = Convert.ToInt32(password);
                        if ((passinput == pass) && (trying < trylimit))
                        {
                            // True pass
                            if ((count == digitlimit) && (setcounter > 1))
                            {
                                pass = passinput;
                                setcounter = 0;
                                Display.Text = "LOCKED";
                                count = 0;
                                password = "";
                                trying = 0;
                            }
                            else if (setcounter == 1)
                            {
                                Display.Text = "NEW PASSWORD:";
                                count = 0;
                                password = "";
                            }


                        }
                        if ((count != digitlimit) && (setcounter == 1))
                        {
                            Display.Text = "MUST BE 4 DIGITS";
                            count = 0;
                        }
                        if ((passinput != pass) && (trying < trylimit) && (setcounter == 1))
                        {
                            // Wrong pass
                            Display.Text = "WRONG PASS";
                            trying++;
                        }
                        if (trying >= trylimit && (setcounter == 1))
                        {
                            // Max amount of tries reached
                            Display.Text = "OUT OF TRIES";
                        }
                    }
                }

            }
            catch (Exception)
            {
                Display.Text = "CANNOT DO THAT";
            }


        }
    }
}
