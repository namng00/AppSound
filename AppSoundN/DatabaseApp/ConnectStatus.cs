using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppSoundN.DatabaseApp
{
    class ConnectStatus
    {
        public static void OpenConnect()
        {
            try {
                if(Database.connect.State==System.Data.ConnectionState.Closed)
                {
                    Database.connect.ConnectionString = Database.GetConnection();
                    Database.connect.Open();
                    MessageBox.Show("Ket noi thanh cong");
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Ket noi ko thanh cong");
            }
        }
        public static void CloseConnect()
        {
            try
            {
                if (Database.connect.State == System.Data.ConnectionState.Open)
                {
                    Database.connect.ConnectionString = Database.GetConnection();
                    Database.connect.Close();
                    MessageBox.Show("Dong ket noi thanh cong");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Dong ket noi ko thanh cong");
            }
        }
    }
}
