using FirstProject_WinForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject_WinForm.Repository
{
    public class RepositoryUser : IEnumerable
    {
        public List<User> users { get; set; }
        public RepositoryUser()
        {
            users = new List<User>();
        }

        public IEnumerator GetEnumerator()
        {
            return users.GetEnumerator();
        }
    }
}
