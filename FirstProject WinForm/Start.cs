using FirstProject_WinForm.Model;
using FirstProject_WinForm.Presenter;
using FirstProject_WinForm.Repository;
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
    public partial class Start : Form
    {
        Sign_up sign_Up;
        Login login;
        public PresenterUser presenterUser;
        public Start()
        {
            InitializeComponent();
            presenterUser = new PresenterUser(new RepositoryUser());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = presenterUser.CheckPass(passTextBox.Text);
            if (user != null)
            {
                login = new Login(user);
                this.Visible = false;
                login.ShowDialog();
                this.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_Up = new Sign_up(this);
            this.Visible = false;
            sign_Up.ShowDialog();
            this.Visible = true;
        }
    }
}
