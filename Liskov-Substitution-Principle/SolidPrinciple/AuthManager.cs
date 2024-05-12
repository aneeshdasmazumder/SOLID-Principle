using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is a class responsible to handle authentication.
 * This class is made "Highly Cohesive" class.
 * Though there are responsiblities like Login(), Logout() etc. etc. still we are grouping them together.
 * If we keep on creating classes for small methods that will be a big issue to maintain.
 * Define the cohesiveness amoung the tasks, methods & modules & group them under proper meaningful purpose.
 */
namespace SolidPrinciple
{
    public class AuthManager
    {
        public void Login() 
        { 
            // Responsible for Login user
        }

        public void Logout() { 
            // Responsible for Logout()
        }

        public Boolean IsCurrentUserAuthenticated()
        { 
            // whether the current user is authenticated or not
            return true;
        }

        public Employee GetCurrentLoggedInUser()
        {
            // get the current logged in user details
            return null;
        }
    }
}
