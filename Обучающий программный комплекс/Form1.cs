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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Reg_b_Click(object sender, EventArgs e)
        {
            if (Surname_box.Text != "" && Name_box.Text != "" && Password_box.Text != "" && Group_box.Text != "")
            {
                string path = @"c:\Files\Регистрация";
                var dir = new DirectoryInfo(path);
                var files = new List<string>();
                foreach (FileInfo file in dir.GetFiles("*.txt"))
                {
                    files.Add(Path.GetFileName(file.FullName));
                }
                foreach (string str in files)
                {
                  
                    if (str == Name_box.Text)
                    {
                        MessageBox.Show("Вы уже Зарегистрированны", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
            else
            {
             MessageBox.Show("Все данные должны быть заполнены", "Ошибка",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Entry_b_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            if (Surname_box.Text != "" && Name_box.Text != "" && Password_box.Text != "" && Group_box.Text != "")
            {
                int end = 0;
                string path = @"c:\Files\Регистрация";
                var dir = new DirectoryInfo(path);
                var files = new List<string>();
                foreach (FileInfo file in dir.GetFiles("*.txt"))
                {
                    files.Add(Path.GetFileName(file.FullName));
                }
                foreach (string str in files)
                {
                    if (str == Name_box.Text && end == 0 )
                    {
                        end = 1;
                        MessageBox.Show("Вы ещё не зарегистрированны", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
       
                    }
                    else
                    if ( end == 0)
                    {
                        end = 1;
                        Form1 MainForm = new Form1();
                        Form2 SecondForm = new Form2();
                        SecondForm.Show();
                        MainForm.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Все данные должны быть заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
