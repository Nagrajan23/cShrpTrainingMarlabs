using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //String strdir = textBox1.Text;
            FileSearch.File fileobj = new FileSearch.File();
            fileobj.sendFileName += SendFileName;
            Thread thread = new Thread(() => fileobj.Search(textBox1.Text));
            thread.Start();
        }

        private void SendFileName(string file)
        {
            MessageBox.Show(file);
            listBox1.Items.Add("Hello Raj");
        }
    }
}
