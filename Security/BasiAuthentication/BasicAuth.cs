using Dal;
using Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class BasicAuth
    {
        public static bool LogIn(string eMail, string password)
        {
            using (var db = new LilHelperEntities())
            {
                return db.User.Any(user => user.EMail.Equals(eMail, StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}
