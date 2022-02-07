using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19
{

    public partial class Form1 : Form
    {
        static public int rezult1;
        static public int rezult2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            вычислитьToolStripMenuItem.Enabled = false;
        }

        private void вводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ввод ввод = new Ввод();
            if (ввод.ShowDialog() == DialogResult.OK)
                вычислитьToolStripMenuItem.Enabled = true;
                
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Вычислить вычислить = new Вычислить();
            вычислить.ShowDialog();
        }
        
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            О_программе опрограмме = new О_программе();
                опрограмме.ShowDialog();
        }
    }
}
