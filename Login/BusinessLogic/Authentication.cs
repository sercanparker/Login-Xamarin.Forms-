using System;
namespace Login.BusinessLogic
{
    /// <summary>
    /// implements methods which are related to Authentication mechanism here.
    /// </summary>
    public class Authentication
    {
        public Authentication()
        {
            
        }

        public bool EmailAndPasswordEditorsAuthenticated(string email, string password)
        {
            
            if (!BussinessLogic.Utilities.String.EmailFitsRegex(email))
            {
                //invalid email 
            }
            if (!BussinessLogic.Utilities.String.PasswordFitsRegex(password))
            {
                //invalid password
            }

            return false;
        }
    }
}
