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
    public partial class Sign_up : Form
    {
        Start start;
        public Sign_up(Start _start)
        {
            InitializeComponent();
            start = _start;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.presenterUser.NewUser(new User(loginTextBox.Text, PassTextBox.Text, nameTextBox.Text, surnameTextBox.Text));
            MessageBox.Show("Complete!");
            this.Close();
        }
    }
}
