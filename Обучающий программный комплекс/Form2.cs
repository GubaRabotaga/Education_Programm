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

namespace Обучающий_программный_комплекс
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Lecture_b_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            Close();
        }

        private void Lab_b_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            Close();
        }

        private void Test_b_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            Close();
        }

        private void Gloss_b_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            Close();
        }

        private void ProgressCheckes_b_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            Close();
        }

        private void About_b_Click(object sender, EventArgs e)
        {

        }

        private void Score_b_Click(object sender, EventArgs e)
        {
            Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
            richTextBox1.Visible = true;
            Back_b.Visible = true;
            string path = @"c:\Files\Регистрация";
            var dir = new DirectoryInfo(path);
            var files = new List<string>();
            int a = 0;
            foreach (FileInfo file in dir.GetFiles("*.txt"))
            {
                files.Add((File.ReadAllLines(file.FullName)).ToString());
                richTextBox1.Text = richTextBox1.Text + files[a].ToString();
                a++;

            }

        }

        private void Exit_b_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_b_Click(object sender, EventArgs e)
        {

        }
    }
}
