using System;
using Login.BusinessLogic.Utilities;
using Xamarin.Forms;

namespace Login
{
    public partial class LoginPage : ContentPage
    {
        private Login.BusinessLogic.Authentication authentication;

        public LoginPage()
        {
            InitializeComponent();
            authentication = new BusinessLogic.Authentication();
        }


        void Handle_Login_Clicked(object sender, System.EventArgs e)
        {
            String email = EmailEditor.Text;
            String password = PasswordEditor.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                DisplayAlert(Resource_ENG.LOGIN_RESULT_MESSAGE_TITLE,
                             Resource_ENG.EMPTY_EDITOR_TEXT_MESSAGE,
                             Resource_ENG.OKEY);
                return;
                
            }
            if (!authentication.EmailAndPasswordEditorsAuthenticated(email,password))
            {
                DisplayAlert(Resource_ENG.LOGIN_RESULT_MESSAGE_TITLE,
                             Resource_ENG.INVALID_AUTHENTICATION_MESSAGE,
                             Resource_ENG.OKEY);
                return;
            }

            DisplayAlert(Resource_ENG.LOGIN_RESULT_MESSAGE_TITLE,
                         Resource_ENG.VALID_LOGIN_MESSAGE,
                         Resource_ENG.OKEY);
            return;
        }



    }
}
