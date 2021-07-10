using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject_WinForm.Model
{
    public class User
    {
        internal List<Label> labels { get; set; }
        internal List<Button> buttons { get; set; }
        public User()
        {
            labels = new List<Label>();
            buttons = new List<Button>();
        }
        public User(string login, string password, string name, string surname)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            labels = new List<Label>();
            buttons = new List<Button>();
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
