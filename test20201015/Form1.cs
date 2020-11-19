using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test20201015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //result = MessageBox.Show(message, caption, buttons);
            int randomNum = new Random().Next(51)+1; //0-100
            MessageBox.Show($"{randomNum}", "random Num", MessageBoxButtons.OK);
        }
    }
}
