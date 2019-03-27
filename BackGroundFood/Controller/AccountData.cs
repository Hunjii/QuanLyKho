using QLKho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Controller
{
    public class AccountData
    {
        private static AccountData instance;
        public static AccountData Instance
        {
            get { if (instance == null) instance = new AccountData(); return instance; }
            set { instance = value; }
        }

        private AccountData() { }

        public bool Login(string userName, string passWord)
        {
            string query = string.Format("Select * from dbo.Account where username = '{0}' and password = '{1}'", userName, passWord);
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account GetAccount(string userName)
        {
            string query = string.Format("SELECT * FROM dbo.Account WHERE username = '{0}'", userName);
            DataTable data = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public DataTable GetListAccount()
        {
            string query = string.Format("Select * from dbo.Account");
            return SqlConnect.Instance.ExecuteQuery(query);
        }

        public bool InsertAccount(string username, string displayname, string password,int type)
        {
            string query = string.Format("INSERT dbo.Account( username, displayname, password, type ) VALUES  ( N'{0}', N'{1}', {2}, {3})", username, displayname, password, type);
            int result = SqlConnect.Instance.ExcuseNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string username, string displayname, string password, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET displayname=N'{0}', type={1}, password={2} where username=N'{3}'", displayname, type, password, username);
            int result = SqlConnect.Instance.ExcuseNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("DELETE dbo.Account WHERE username = N'{0}'", username);
            int result = SqlConnect.Instance.ExcuseNonQuery(query);

            return result > 0;
        }
    }
}
