using FirstProject_WinForm.Model;
using FirstProject_WinForm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject_WinForm.Presenter
{
    public class PresenterUser
    {
        RepositoryUser repository;
        public bool rightLogin { get; set; }
        public PresenterUser(RepositoryUser _repository)
        {
            repository = _repository;
            rightLogin = false;
        }
        public User CheckUser(string login, string pass = "")
        {
            rightLogin = false;
            for (int i = 0; i < repository.users.Count; i++)
            {
                if (repository.users[i].Login == login)
                {
                    if (repository.users[i].Password == pass)
                    {
                        return repository.users[i];
                    }
                    rightLogin = true;
                    break;
                }
            }
            return null;
        }
        public void NewUser(User newUser)
        {
            repository.AddUser(newUser);
        }
    }
}
