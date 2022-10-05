using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    internal class LogOutUser:CommonMethods
    {
        By loginButton = By.XPath("//a[@href='/login']");
        By userEmail = By.XPath("//input[@data-qa='login-email']");
        By userPassword = By.XPath("//input[@data-qa='login-password']");
        By logInToAccountButton = By.XPath("//button[@data-qa='login-button']");
        By logOutTheUser = By.XPath("//i[@class='fa fa-lock']");
        By verifyUser = By.XPath("//b");
        By verifyOnHomePage = By.XPath("//h2[text()='Login to your account']");


        public void userLogOut(string emailOfUser, string passwordOfUser)
        {
            Click(loginButton);
            Write(userEmail, "byk.isr@gmail.com");
            Write(userPassword, "Babar12345");
            Click(logInToAccountButton);
            Wait(3000);
            Asserting(verifyUser);

        }
        public void logoutP()
        {
            Click(logOutTheUser);
            Asserting(verifyOnHomePage);

        }
    }
}
