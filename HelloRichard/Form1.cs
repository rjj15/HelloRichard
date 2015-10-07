//Richard Johnson.  This program takes a stock ticker input, puts together a http string, and queries yahoo for stock price

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace HelloRichard
{
 
    public partial class Form1 : Form
    {
        public int up1 = 0;
        public int checkred = 4;  //to check if current quote is negative
        public string ticker1="";
        public string yahoo = "http://download.finance.yahoo.com/d/quotes.csv?s=";
        public string endyahoo = "&f=sl1d1t1c1ohgv&e=.csv";
    //lists are not being used yet
        public List<string> data = new List<string>();
        public List<string>titles = new List<string>();
        public List<string>row = new List<string>();
        List<string> Stockcollection = new List<string>();
        public Form1()
        {
            InitializeComponent();
            titles.Add("Ticker");
            titles.Add("Price");
            titles.Add("Date");
            titles.Add("Time");
            titles.Add("Change");
            titles.Add("Open");
            titles.Add("Day high");
            titles.Add("Day Low");
            titles.Add("Volume");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ticker1 = TB1.Text;
            TB2.Text = yahoo + ticker1 +endyahoo;
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++up1;
            LB1.Text = "Count is: " + up1;
            if (!String.IsNullOrWhiteSpace(TB1.Text))
            {
                //send value of TB1 to Output for debugging
                System.Diagnostics.Trace.WriteLine("TB1" + TB1);
                var url = TB2.Text;
                //string url = TB2.text;
                RT1.Text += DownloadString(url);
                string text = RT1.Text;
                char[] separatingChars = { '"', '"', ',', ',' };
                string[] words = text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
                System.Console.WriteLine("words4 is:" +words[checkred]);
                
                if (words[checkred].Contains("-"))

                {
                    //if stock is negative change background to Red
                    RT1.BackColor = System.Drawing.Color.Red;
                    words[4] = null;
                    System.Console.WriteLine("after setting words4 to null it is" + words[4]);
                    text = null;
                }
                else
                {
                    RT1.BackColor = System.Drawing.Color.Yellow;
                    words[4] = null;
                    text = null;
                }
                checkred = checkred + 9;
                //foreach (string s in words)
                // {

                // System.Console.WriteLine(words(s));
                // }


            }

            else
            {
                MessageBox.Show("empty Ticker!");

            }
        
        }
        public static String DownloadString(string address)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(address);
            //RT1.AppendText(String.Format(reply));
            return reply;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quit Really!!");
            Application.Exit();
        }
    }
}
