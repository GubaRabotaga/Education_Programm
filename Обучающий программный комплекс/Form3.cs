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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


        }

    
        public void Form3_Load(object sender, EventArgs e)
        {
           
                foreach (Button button in this.Controls)
                {
                    string path = @"c:\Files\Ресурсы";
                    var dir = new DirectoryInfo(path);
                    int a = 0;
                    foreach (FileInfo file in dir.GetFiles("*.rtf"))
                    {
                        Controls[a].Text = Path.GetFileName(file.FullName).ToString();
                        Controls[a].Text = Controls[a].Text.Replace(".rtf", "").Trim();
                        a++;
                    }
                    if (button.Text == "")
                    {
                        button.Visible = false;
                    }

                }
          
     
        }

        private void Back_b_Click(object sender, EventArgs e)
        {
            Close();
            Form2 SecondForm = new Form2();
            SecondForm.Show();
        }

        public void Chose_b28_Click(object sender, EventArgs e)
        {
            Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
            RichTextBox textbox = new RichTextBox();
            Button btn = new Button();
            textbox.Location = new Point(40, 10);
            textbox.Height = 638;
            textbox.Width = 960;
            textbox.BorderStyle = BorderStyle.None;
            textbox.BackColor = Color.Honeydew;
            btn.Location = new Point(1, 1);
            btn.Height = 30;
            btn.Text = "Вернуться назад";
            btn.BackColor = Color.Honeydew;
            btn.Width = 140;
            this.Controls.Add(textbox);
            this.Controls.Add(btn);
            btn.BringToFront();
            btn.Click += new EventHandler(btn_Click);
            textbox.LoadFile(@"c:\Files\Ресурсы", RichTextBoxStreamType.RichText);
        }
        private void btn_Click(object sender, EventArgs e) 
        {
            Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
            try
            {
                foreach (Button button in this.Controls)
                {
                    string path = @"c:\Files\Ресурсы";
                    var dir = new DirectoryInfo(path);
                    int a = 0;
                    foreach (FileInfo file in dir.GetFiles("*.rtf"))
                    {
                        Controls[a].Text = Path.GetFileName(file.FullName).ToString();
                        Controls[a].Text = Controls[a].Text.Replace(".rtf", "").Trim();
                        a++;
                    }
                    if (button.Text == "")
                    {
                        button.Visible = false;
                    }
                    else
                    {
                        button.Visible = true;
                    }

                }
            }
            catch
            {

            }

        }
    }
}
