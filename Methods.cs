using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_Regex_Assignment
{
    class Methods
    {
        public static void FirstNameInput()
        {
            UserInput user = new UserInput();
            Pattern patterns = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter your first name :");
                user.fName = Console.ReadLine();
                bool Status = patterns.validateName(user.fName);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;

                }
                else
                {
                    Console.WriteLine("Rejected");
                }
            }
        }

        public static void LastNameInput()
        {
            UserInput user = new UserInput();
            Pattern patterns = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter your last name :");
                user.lName = Console.ReadLine();
                bool Status = patterns.validateName(user.lName);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;

                }
                else
                {
                    Console.WriteLine("Rejected");
                }
            }
        }

        public static void EmailInput()
        {
            UserInput user = new UserInput();
            Pattern pattern = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter Gmail :");
                user.email = Console.ReadLine();
                bool Status = pattern.validateEmail(user.email);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;
                }
                else
                {
                    Console.WriteLine("rejected");
                }
            }
        }
        public static void MobileNumInput()
        {
            UserInput user = new UserInput();
            Pattern pattern = new Pattern();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Enter your mobile number");
                user.mobileNum = Console.ReadLine();
                bool Status = pattern.validateMobileNum(user.mobileNum);
                if (Status == true)
                {
                    Console.WriteLine("Accepted");
                    status = true;
                }
                else
                {
                    Console.WriteLine("Rejected");
                }
            }
        }
        public static void PasswordInput()
        {
            Pattern pattern = new Pattern();
            UserInput user = new UserInput();
            bool status = false;
            while (status != true)
            {
                Console.WriteLine("Please enter password");
                user.password = Console.ReadLine();
                bool Status = pattern.validatePassword(user.password);
                if (Status == true)
                {

                    Console.WriteLine("Accepted");
                    status = true;
                }
                else
                {
                    Console.WriteLine("Rejected");
                }
            
            }
        }
    }
}
