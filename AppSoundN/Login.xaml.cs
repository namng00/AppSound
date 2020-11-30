using AppSoundN.Class;
using AppSoundN.DatabaseApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppSoundN
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        public static bool ConverByteToBool(int cb)
        {
            if (cb == 1) return true; else return false;
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(tbEmail.Text.Trim(), tbPassword.Password.Trim(),false);
            User admin = new User(tbEmail.Text.Trim(), tbPassword.Password.Trim(), true);
            if(Account.CheckAccountDatabase(admin.Email, admin.Password,admin.Permisstion))
            {
                MessageBox.Show("dang nhap thanh cong tk admin");
            }
            else if(Account.CheckAccountDatabase(user.Email, user.Password, user.Permisstion))
            { 
                MessageBox.Show("dang nhap thanh cong user");
            }
            else
            {
                MessageBox.Show("dang nhap that bai");
            }   
            
        }

        
    }
}
