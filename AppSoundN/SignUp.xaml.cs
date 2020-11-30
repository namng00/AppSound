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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if(tbPasswordSignUp.Password==tbConfirmPassword.Password)
            {
                if(cbAgreed.IsChecked==true)
                {
                    if (Account.InsertTableAccout(tbEmailSignUp.Text.Trim(), tbPasswordSignUp.Password))
                    {
                        MessageBox.Show("Dang ki thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Dang ki That bai");
                    }
                }
                else
                {
                    MessageBox.Show("Mời bạn chấp nhận điều khoản");
                }    
                
            }
            else
            {
                MessageBox.Show("Xác nhận lại mật khẩu");
            }    
        }
    }
}
