using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingRandomNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                
                int num;
                int sum=0;
                int count=0;
                StreamReader inputFile = new StreamReader(ofdOpenFile.FileName);
                while (!inputFile.EndOfStream)
                {
                    num = Convert.ToInt32(inputFile.ReadLine());
                    sum = sum + num;
                    count++;
                    lstBoxOutput.Items.Add(num);
                }
                lstBoxOutput.Items.Add("Sum of the numbers in File: " + sum);
                lstBoxOutput.Items.Add("Count of the numbers in File: " + count);
            }

        }
    }
}
