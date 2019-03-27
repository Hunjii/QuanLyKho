using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Models
{
    public class Account
    {
        public Account(string userName, int type, string passWord = null)
        {
            this.userName = userName;
            this.type = type;
            this.passWord = passWord;
        }

        public Account(DataRow row)
        {
            this.userName = row["username"].ToString();
            this.type = (int)row["type"];
            this.passWord = row["password"].ToString();
        }
        private string userName;

        public string UserName
        { get {  return userName; }
          set { userName = value; }
        }

        private string passWord;
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private int type;
        public int Type
        { get { return type; }
          set { type = value; }
        }


    }
}
