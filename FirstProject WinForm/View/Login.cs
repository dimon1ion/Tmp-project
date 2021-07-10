using FirstProject_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject_WinForm
{
    public partial class Login : Form
    {
        User user;
        Label editComment;
        public Login(User _user)
        {
            InitializeComponent();
            user = _user;
            this.Text = "Hi " + user.Name + ' ' + user.Surname + '!';
            for (int i = 0; i < user.labels.Count; i++)
            {
                this.Controls.Add(user.labels[i]);
                this.Controls.Add(user.buttons[i]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Edit")
            {
                editComment.Text = $"{user.Name} {user.Surname}\n{textBox1.Text}";
                (sender as Button).Text = "Save";
                textBox1.Text = String.Empty;
                return;
            }
            Label label = new Label();
            Button button = new Button();
            label.AutoSize = true;
            //label.Height += 11 + (n * 17);
            //label.Width = 70000;
            label.Text = $"{user.Name} {user.Surname}\n";
            int i = 0, n = 0;
            foreach (var letter in textBox1.Text)
            {
                if (i == 100)
                {
                    label.Text += '\n';
                    n++;
                    i = 0;
                }
                if (letter == '\n')
                {
                    n++;
                }
                label.Text += letter;
                i++;
            }
            int y = 0;
            for (int count = 0; count < user.labels.Count; count++)
            {
                y += user.labels[count].Height;
            }
           
            label.Top = y;
            label.Left = 10;
            this.Controls.Add(label);
            
            button.Text = "Edit";
            button.Height = 20;
            button.Width = 50;
            button.Left = label.Width + 10;
            button.Top = y;
            button.Click += Button_Click;
            this.Controls.Add(button);
            user.labels.Add(label);
            if (label.Top + label.Height > groupBox1.Top)
            {
                groupBox1.Top = label.Top + label.Height;
            }
            user.buttons.Add(button);
            //textBox1.Text = String.Empty;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                int i = 0;
                bool found = false;
                for (; i < user.buttons.Count; i++)
                {
                    if (sender == user.buttons[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    addButton.Text = "Edit";
                    editComment = user.labels[i];
                    string[] tmp = user.labels[i].Text.Split('\n');
                    textBox1.Text = String.Empty;
                    for (int j = 1; j < tmp.Length; j++)
                    {
                        textBox1.Text += tmp[j] + '\n';
                    }
                }
            }
        }
    }
}
