using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace spammer
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "100";
            label5.Text = "100";
            label6.Text = "1";
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            string text = "Created by Nangito, enjoy :)";
            MessageBox.Show(text);
            macTrackBar1.Maximum = 1000;
            macTrackBar2.Maximum = 1000;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            timer3.Start();
            timer3.Interval = 100;
            
    
        }

        public static class Teszt
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = macTrackBar1.Value;

            SendKeys.Send(textBox1.Text);

            // SendKeys.Send("{ENTER}");

            //textBox1.Text = W;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            conta_jogadas++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            conta_jogadas = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "You found an easter egg ;-)";
            string jebaited = "https://www.youtube.com/watch?v=d1YBv2mWll0";
            MessageBox.Show(jebaited);
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            string text = "This is the reference for the interval in miliseconds";
            MessageBox.Show(text);
        }

        private void macTrackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = macTrackBar1.Value.ToString();
        }
        

        private void macTrackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = macTrackBar2.Value.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             timer2.Interval = macTrackBar2.Value;
                       
             if (checkBox1.Checked == true)
             {
                 SendKeys.Send("{ENTER}");
             }

           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string text = "This is the reference for the interval in miliseconds";
            MessageBox.Show(text);
        }

        private void macTrackBar3_Scroll(object sender, EventArgs e)
        {
            label6.Text = macTrackBar3.Value.ToString();
        }

        private void macTrackBar3_ValueChanged(object sender, decimal value)
        {
            if (checkBox2.Checked == true)
            {
                if (macTrackBar3.Value == 1)
                {
                    macTrackBar1.TickFrequency = 100;
                    macTrackBar2.TickFrequency = 100;
                }

                if (macTrackBar3.Value > 1)
                {
                    macTrackBar1.TickFrequency = 1000;
                    macTrackBar2.TickFrequency = 1000;
                }
            }
            
            
            
            if (checkBox2.Checked == true)
            {

                var Setmax2 = macTrackBar3.Value * 1000;
                macTrackBar2.Maximum = Setmax2;
            }

            if (checkBox2.Checked == false)
            {
                macTrackBar2.Maximum = 1000;
            }

            if (checkBox2.Checked == true)
            {
                var Setmax1 = macTrackBar3.Value * 1000;
                macTrackBar1.Maximum = Setmax1;
            }

            if (checkBox2.Checked == false)
            {
                macTrackBar1.Maximum = 1000;
            }

            return;

            
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            macTrackBar1.Maximum = macTrackBar3.Value * 1000;
            macTrackBar2.Maximum = macTrackBar3.Value * 1000;

             
        }

        

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            MessageBox.Show("Work in progress!44!!!!44!(Not working and supper buggy)");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    timer1.Start();
                    
                    filePath = openFileDialog.FileName;
                    
                    StreamReader streamReader = new StreamReader(filePath); 
                    string stringWithMultipleSpaces = streamReader.ReadToEnd(); 
                    streamReader.Close();

                    Regex r = new Regex(" +"); 
                    string[] words = r.Split(stringWithMultipleSpaces); 
                    
                   
                    foreach (String W in words)
                    {

                        if (conta_jogadas >= 0)
                        {
                            textBox1.Text = W;
                        }
                                              

                        Task.Delay(macTrackBar1.Value).Wait();
                        
                    }


                }
            }
                
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string info = "If you turned off or changed the value of the multiplier you need to slide the slider or they will be stuck at the miliseconds as they were. There is an EasterEgg hiden in the app if you find it you are good :) -Nangito";
            MessageBox.Show(info);
        }

              
        
        private int conta_jogadas;

        private void RNG(object sender, EventArgs e)
        {
            
                    
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var random = new System.Random();
            int RandomizedNumber = random.Next(0, 1000);

            // max velue test

            var MaxInterval = 1;

            if(checkBox2.Checked == true)
            {
                MaxInterval = macTrackBar3.Value * 1000;
            }
            else
            {
                MaxInterval = 1000; 
            }

            //

            if(checkBox3.Checked == true)
            {
                macTrackBar1.Value = RandomizedNumber;
                label2.Text = RandomizedNumber.ToString();
                
                
            }
        }

        
    }
}

