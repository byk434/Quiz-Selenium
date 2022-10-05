using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    internal class SignInUser:CommonMethods
    {
        By loginButton = By.XPath("//a[@href='/login']");
        By userEmail = By.XPath("//input[@data-qa='login-email']");
        By userPassword = By.XPath("//input[@data-qa='login-password']");
        By logInToAccountButton = By.XPath("//button[@data-qa='login-button']");
        By deleteAccount = By.XPath("//i[@class='fa fa-trash-o']");
        By verifyUser = By.XPath("//b");


        public void userLogIn(string emailOfUser, string passwordOfUser)
        {
            Click(loginButton);
            Write(userEmail, "byk.isr@gmail.com");
            Write(userPassword, "Babar12345");
            Click(logInToAccountButton);
            Asserting(verifyUser);
            Click(deleteAccount);
        }
    }
}
