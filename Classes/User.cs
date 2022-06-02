using C969Rebekah.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleProgram.Classes
{
    public class User : Person
    {
        public int UserID;
        public string UserName;
        public string Password;
        //public byte Active;
        //public DateTime CreateDate;
        //public string CreatedBy;
        //public DateTime LastUpdate;
        //public string LastUpdateBy;

        public User(int userID, string userName, string password, int active, DateTime createDate)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Active = (byte)active;
            CreateDate = createDate;
         
        }
    }
}

