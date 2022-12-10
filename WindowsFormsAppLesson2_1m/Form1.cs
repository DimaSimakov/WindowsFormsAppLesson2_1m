using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson2_1m
{
    //МЕТОД ИНИЦИЛИЗАЦИИ
    public partial class Form1 : Form
    {
        //МЕТОД ЗАГРУЗКИ ФОРМЫ
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Не нажимай";
            label1.Text = "made by Progtime";
            textBox1.Text = "Cотри тут";
        }
        //МЕТОД НАЖАТИЯ НА КНОПКУ
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "=^_^=";
            button1.BackColor = Color.Blue;
            button1.Enabled = false;
            label1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        //метод нажатия на кнопку 2
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Black;
            button1.Text = "Не нажимай";
        }
    }
}
