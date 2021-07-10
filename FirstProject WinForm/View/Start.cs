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
            presenterUser = new PresenterUser(new RepositoryUser(Application.StartupPath));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorPasswordLabel.Text = String.Empty;
            errorLoginLabel.Text = String.Empty;
            User user = presenterUser.CheckUser(loginTextBox.Text, passTextBox.Text);
            if (user != null)
            {
                login = new Login(user);
                this.Visible = false;
                login.ShowDialog();
                this.Visible = true;
            }
            else if (presenterUser.rightLogin)
            {
                errorPasswordLabel.Text = "*Password is incorrect";
            }
            else
            {
                errorLoginLabel.Text = "*Login not found";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_Up = new Sign_up(this);
            this.Visible = false;
            if (sign_Up.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }
            this.Visible = true;
        }
    }
}
