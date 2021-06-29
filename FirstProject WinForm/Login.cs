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
        public Login(User _user)
        {
            InitializeComponent();
            user = _user;
            this.Text = user.Name + ' ' + user.Surname;
            for (int i = 0; i < user.labels.Count; i++)
            {
                this.Controls.Add(user.labels[i]);
                this.Controls.Add(user.buttons[i]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            Button button = new Button();
            label.Text = $"{user.Name} {user.Surname}\n";
            int i = 0, n = 0;
            foreach (var letter in textBox1.Text)
            {
                if (i == 20)
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
            label.Height += 11 + (n * 17);
            label.Width = 500;
            button.Text = "Edit";
            button.Left = 500;
            button.Top = y;
            user.labels.Add(label);
            this.Controls.Add(label);
        }
    }
}
