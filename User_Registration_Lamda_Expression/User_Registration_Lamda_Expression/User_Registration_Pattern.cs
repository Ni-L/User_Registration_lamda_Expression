using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace User_Registration_Lamda_Expression
{/// <summary>
/// User-Registration Patterns for FirstNAme,LastName,Email,PhoneNumber,Password
/// </summary>
    public class User_Registration_Pattern

    {
        //Pattern for FirstName Start With Caps And Should And Has minimum Three Character.
        public const string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Pattern for LastName Start With Caps And Should And Has minimum Three Character.
        public const string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        //User needs to Enter valid Email Id 
        public const string Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        //Pattern for phone number should be with country code and 10 digit Number
        public const string PhoneNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        //Pattern for Password should be special character,caps,number,character
        public const string Password = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";
        public bool ValidateFirstName(string firstName)//Method for Firstname Validation
        {
            try
            {
                Regex regexObj = new Regex(FirstName);

                //call the IsMatch metod to determine whether a match is present and store in result variable
                bool result = regexObj.IsMatch(firstName);
                return result;

            }
            catch (User_RegistrationException)
            {
                throw new User_RegistrationException(User_RegistrationException.ExceptionType.INVALID_FIRSTNAME, "First Name Should be Capital");
            }
        }
        public bool ValidateLastName(string lastName)//Method For LastName Validation
        {
            try
            {
                Regex regexObj1 = new Regex(LastName);
                bool result = regexObj1.IsMatch(lastName); //call the IsMatch metod to determine whether a match is present
                                                           //and store in result variable
                return result;
            }
            catch (User_RegistrationException)
            {
                throw new User_RegistrationException(User_RegistrationException.ExceptionType.INVALID_LASTNAME, "Last Name Should Be in Capital");
            }
        }
        public bool ValidateEmail(string email)//Method for Email Validation
        {
            try
            {
                Regex regexObj2 = new Regex(Email);
                bool result = regexObj2.IsMatch(email);//call the IsMatch metod to determine whether a match is present
                                                       //and store in result variable
                return result;
            }
            catch (User_RegistrationException)
            {
                throw new User_RegistrationException(User_RegistrationException.ExceptionType.INVALID_EMAIL_ID, "Invalid Email Address Please Enter Again");
            }
        }
        public bool ValidateMobile(string phoneNumber)//Method for Phone Number Validation
        {
            try
            {
                Regex regexObj3 = new Regex(PhoneNumber);
                bool result = regexObj3.IsMatch(phoneNumber);//call the IsMatch metod to determine whether a match is present
                                                             //and store in result variable
                return result;
            }
            catch (User_RegistrationException)
            {
                throw new User_RegistrationException(User_RegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Enter Valid PhoneNumber");
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                Regex regexObj4 = new Regex(Password);
                bool result = regexObj4.IsMatch(password);//call the IsMatch metod to determine whether a match is present
                return result;
            }
            catch (User_RegistrationException)
            {
                throw new User_RegistrationException(User_RegistrationException.ExceptionType.INVALID_PASSWORD, "Enter Valid Password With One Special Character");
            }
        }
        class Program
        /// <summary>
        /// Using Lambda Expression
        /// </summary>
        {
            public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, FirstName));
            public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, LastName));
            public bool ValidateEmail(string email) => (Regex.IsMatch(email, Email));
            public bool ValidateMobile(string mobNumber) => (Regex.IsMatch(mobNumber, PhoneNumber));
            public bool ValidatePassword(string password) => (Regex.IsMatch(password, Password));
        }
    }
}

