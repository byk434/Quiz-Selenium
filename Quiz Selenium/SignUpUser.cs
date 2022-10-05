using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    public class SignUpUser: CommonMethods
    {
        By loginButton = By.XPath("//a[@href='/login']");
        By newUserName = By.XPath("//input[@data-qa='signup-name']");
        By newUserEmail = By.XPath("//input[@data-qa='signup-email']");
        By signUpButton = By.XPath("//button[@data-qa='signup-button']");
        By genderButton = By.XPath("//input[@id='id_gender1']");
        By newPassword = By.XPath("//input[@id='password']");
        By birthDate = By.XPath("(//option[@value='9'])[1]");
        By birthMonth = By.XPath("(//option[@value='9'])[2]");
        By birthYear = By.XPath("//option[@value='1996']");
        By newsLetter = By.XPath("//input[@id='newsletter']");
        By firstNameOfUser = By.XPath("//input[@id='first_name']");
        By lastNameOfUser = By.XPath("//input[@id='last_name']");
        By companyName = By.XPath("//input[@id='company']");
        By addressOne = By.XPath("//input[@id='address1']");
        By addressTwo = By.XPath("//input[@id='address2']");
        By countryName = By.XPath("//option[@value='United States']");
        By stateName = By.XPath("//input[@id='state']");
        By cityName = By.XPath("//input[@id='city']");
        By zipCode = By.XPath("//input[@id='zipcode']");
        By mobileNumber = By.XPath("//input[@id='mobile_number']");
        By createAnAccountButton = By.XPath("//button[@data-qa='create-account']");
        By continueButton = By.XPath("//a[@data-qa='continue-button']");
        By deleteAccount = By.XPath("//i[@class='fa fa-trash-o']");
        By accountDelete = By.XPath("//button[@class='btn btn-danger']");
        By verifyAccount = By.XPath("//p[text()='Congratulations! Your new account has been successfully created!']");
        By verifyNewSignUp = By.XPath("//h2[text()='New User Signup!']");
        By verifyInfo = By.XPath("//b[text()='Enter Account Information']");
        By verifyUserN = By.XPath("//b");
        public void RegisterUser(string userName, string userEmail, string enterPassword, string firtName, 
        string lastName, string nameOfCompany, string address1, string address2, string nameOfState, string nameOfCity, 
        string codeZip, string numberMobile)
        {
            Click(loginButton);
            Asserting(verifyNewSignUp);
            Write(newUserEmail, userEmail);
            Write(newUserName, userName);
            Click(signUpButton);
            Asserting(verifyInfo);
            Click(genderButton);
            Write(newPassword, enterPassword);
            Click(birthDate);
            Click(birthMonth);
            Click(birthYear);
            ScrollToElement(companyName);
            Click(newsLetter);
            Write(firstNameOfUser, firtName);
            Write(lastNameOfUser, lastName);
            Write(companyName, nameOfCompany);
            ScrollToElement(mobileNumber);
            Write(addressOne, address1);
            Write(addressTwo, address2);
            Click(countryName);
            Write(stateName, nameOfState);
            Write(cityName, nameOfCity);
            Write(zipCode, codeZip);
            Write(mobileNumber, numberMobile);
            Click(createAnAccountButton);
            Asserting(verifyAccount);
            

        }
        public void continueB()
        {
            Asserting(verifyUserN);
            Click(continueButton);
            Click(deleteAccount);
            Click(accountDelete);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\ScreenshotSignUpUser.png", ScreenshotImageFormat.Png);

        }



    }
}
