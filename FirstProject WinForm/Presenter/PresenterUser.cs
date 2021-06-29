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
        public PresenterUser(RepositoryUser _repository)
        {
            repository = _repository;
        }
        public User CheckPass(string pass)
        {
            for (int i = 0; i < repository.users.Count; i++)
            {
                if (repository.users[i].Password == pass)
                {
                    return repository.users[i];
                }
            }
            return null;
        }
        public void NewUser(User newUser)
        {
            repository.users.Add(newUser);
        }
    }
}
