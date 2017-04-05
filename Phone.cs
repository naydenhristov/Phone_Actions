using System;
using System.Linq;

namespace Task2_4_Phone
{
    class Phone
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] command = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string action = string.Empty;

            while (command[0] != "done")
            {
                switch (command[0])
                {
                    case "call": 
                        action = Call(command[1], names, phoneNumbers);
                        Console.WriteLine(action);
                        break;
                    case "message" :
                        action = Message(command[1], names, phoneNumbers);
                        Console.WriteLine(action);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine()
                .Split(' ')
                .ToArray();
            }
        }

        private static string Call(string nameOrPhoneNumber, string[] name, string[] phoneNumber)
        {
            string callResult = string.Empty;
            string oppositeElement = string.Empty;
            int sumOfDigits = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (nameOrPhoneNumber == name[i])
                {
                    oppositeElement = phoneNumber[i];
                    sumOfDigits = SumOfDigits(phoneNumber[i]);
                }
                else if (nameOrPhoneNumber == phoneNumber[i])
                {
                    oppositeElement = name[i];
                    sumOfDigits = SumOfDigits(phoneNumber[i]);
                }
            }

            int minutes = sumOfDigits / 60;
            int seconds = sumOfDigits % 60;

            if (sumOfDigits % 2 == 0)
            {
                callResult = "calling " + oppositeElement + "..." + Environment.NewLine + 
                    "call ended. duration: " + minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }
            else
            {
                callResult = "calling " + oppositeElement + "..." + Environment.NewLine + "no answer";
            }

            return callResult;
        }

        private static string Message(string nameOrPhoneNumber, string[] name, string[] phoneNumber)
        {
            string messageResult = string.Empty;
            string oppositeElement = string.Empty;
            int differenceOfDigits = 0;
            
            for (int i = 0; i < name.Length; i++)
            {
                if (nameOrPhoneNumber == name[i])
                {
                    oppositeElement = phoneNumber[i];
                    differenceOfDigits = DifferenceOfDigits(phoneNumber[i]);
                }
                else if (nameOrPhoneNumber == phoneNumber[i])
                {
                    oppositeElement = name[i];
                    differenceOfDigits = DifferenceOfDigits(phoneNumber[i]);
                }
            }

            if (differenceOfDigits % 2 == 0)
            {
                messageResult = "sending sms to " + oppositeElement + "..." + Environment.NewLine + "meet me there";
            }
            else
            {
                messageResult = "sending sms to " + oppositeElement + "..." + Environment.NewLine + "busy";
            }

            return messageResult;
        }

        private static int DifferenceOfDigits(string p)
        {
            int digit = 0;
            int difference = 0;

            foreach (char symbol in p)
            {
                digit = symbol - '0';
                if (digit >= 0 && digit <= 9)
                {
                    difference -= digit;
                }
            }

            return Math.Abs(difference);
        }

        private static int SumOfDigits(string p)
        {
            int digit = 0;
            int sum = 0;

            foreach (char symbol in p)
            {
                digit = symbol - '0';
                if (digit >= 0 && digit <= 9)
                {
                    sum += digit;
                }
            }

            return sum;
        }
       
    }
}
