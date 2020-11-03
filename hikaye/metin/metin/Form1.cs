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


namespace metin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi;
            Random r = new Random();
            sayi = r.Next(20);

            StreamReader SR = new StreamReader("C:\\Users\\BATUHAN\\Desktop\hikaye\\metinler" + sayi.ToString() + ".txt");
            richTextBox1.Text = SR.ReadLine();
            SR.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            this.Hide();
            x.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Application.Exit();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
          
        }   
    }
}
