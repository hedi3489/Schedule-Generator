using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForFinal_Exam.DataAccess;

namespace ReviewForFinal_Exam.Business
{
    public class User
    {
        public int UserName { get; set; }
        public string Password { get; set; }

        public string GetJobTitle(int userId)
        {
            return UserDA.GetJobName(userId);
        }

        public bool IsValidUser (User user)
        {
            return UserDA.IsValidUser(user);
        }

    }
}
