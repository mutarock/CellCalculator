using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CellCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset() 
        {
            //Console.WriteLine("Reset"); 
            eachCount = new int[12];
            totalCount = 0;
            textBox0.Text = "0";
            textBox1.Text= "0";
            textBox2.Text= "0";
            textBox3.Text= "0";
            textBox4.Text= "0";
            textBox5.Text= "0";
            textBox6.Text= "0";
            textBox7.Text= "0";
            textBox8.Text= "0";
            textBox9.Text= "0";
            textBox10.Text = "0";
            textBox10.Text = "0";
            textBoxdot.Text= "0";
            textBoxplus.Text= "0";
        }

        public void onePing()
        {
            SystemSounds.Beep.Play();
        }

        public void updateTotalBox() {
            textBox10.Text = totalCount.ToString();
        }

        private void form1_keydown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyCode);
            //onePing();

            if (totalCount == 100 && e.KeyCode != Keys.Enter)
            {
                onePing();
                return;
            }

            switch (e.KeyCode) 
            {
                case Keys.NumPad0:
                    eachCount[0] += 1;
                    //totalCount++;
                    textBox0.Text = eachCount[0].ToString();
                    break;

                case Keys.NumPad1:
                    eachCount[1] += 1;
                    totalCount++;
                    textBox1.Text = eachCount[1].ToString();
                    break;

                case Keys.NumPad2:
                    eachCount[2] += 1;
                    totalCount++;
                    textBox2.Text = eachCount[2].ToString();
                    break;

                case Keys.NumPad3:
                    eachCount[3] += 1;
                    totalCount++;
                    textBox3.Text = eachCount[3].ToString();
                    break;

                case Keys.NumPad4:
                    eachCount[4] += 1;
                    totalCount++;
                    textBox4.Text = eachCount[4].ToString();
                    break;

                case Keys.NumPad5:
                    eachCount[5] += 1;
                    totalCount++;
                    textBox5.Text = eachCount[5].ToString();
                    break;

                case Keys.NumPad6:
                    eachCount[6] += 1;
                    totalCount++;
                    textBox6.Text = eachCount[6].ToString();
                    break;

                case Keys.NumPad7:
                    eachCount[7] += 1;
                    totalCount++;
                    textBox7.Text = eachCount[7].ToString();
                    break;

                case Keys.NumPad8:
                    eachCount[8] += 1;
                    totalCount++;
                    textBox8.Text = eachCount[8].ToString();
                    break;

                case Keys.NumPad9:
                    eachCount[9] += 1;
                    totalCount++;
                    textBox9.Text = eachCount[9].ToString();
                    break;

                case Keys.Enter:
                    reset();
                    break;

                case Keys.Decimal:
                    eachCount[10] += 1;
                    totalCount++;
                    textBoxdot.Text = eachCount[10].ToString();
                    break;

                case Keys.Add:
                    eachCount[11] += 1;
                    totalCount++;
                    textBoxplus.Text = eachCount[11].ToString();
                    break;

            }

            updateTotalBox();

        }


    }
}
