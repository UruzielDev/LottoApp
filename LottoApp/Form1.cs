using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        private static readonly Random rnd = new Random();
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox2.Items.Count < 5)
            {
                int index = rnd.Next(listBox1.Items.Count);
                int number = (int)listBox1.Items[index];
                listBox2.Items.Add(number);
                listBox2.SetSelected(listBox2.Items.Count - 1, true);
                listBox1.Items.RemoveAt(index);
            }
            if (listBox2.Items.Count == 5)
            {
                generateButton.Enabled = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 1; i <= 50; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
