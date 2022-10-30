using Basic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Core
{
    public static class UserLogic
    {
        public static User FindUserByFirstName(List<User> users, string firstName)
            => users.FirstOrDefault(user => user.FirstName == firstName);

        public static bool Validate(string login, string password) =>
            login == "tatiana" && password == "0304";
    }
}
