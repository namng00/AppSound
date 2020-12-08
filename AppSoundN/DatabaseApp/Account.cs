using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppSoundN.DatabaseApp
{
    class Account 
    {
        public static bool CheckAccountDatabase(string email,string password, bool permisson)
        {
            string sql = $"select count(*) from Account where Email=@Email and Password=@Password and Permisson=@Permisson";
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text ;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@Password", password);
                Database.command.Parameters.AddWithValue("@Permisson", permisson);
                int count = Convert.ToInt32(Database.command.ExecuteScalar().ToString());
                if (count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                ConnectStatus.CloseConnect();

            }
        }

        

        public static bool InsertTableAccout(string email, string password)
        {
            String sql=$"insert into Account values(@Email,@Password,0);";
            
            try
            {
                ConnectStatus.OpenConnect();
                Database.command.CommandType = CommandType.Text;
                Database.command.CommandText = sql;
                Database.command.Parameters.Clear();
                Database.command.Parameters.AddWithValue("@Email", email);
                Database.command.Parameters.AddWithValue("@Password", password);
                Database.command.ExecuteScalar();
                return true;

            }
            catch(Exception e)
            {
                return false;   
            }
            finally
            {
                ConnectStatus.CloseConnect();
            }
        }

        
    }
}


