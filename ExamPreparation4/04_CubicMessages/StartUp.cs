using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _04_CubicMessages
{
    public class StartUp
    {
        public static void Main()
        {
            string firstInput;
            string secondInput;

            List<Message> messages = new List<Message>();

            while ((firstInput = Console.ReadLine()) != "Over!" && (secondInput = Console.ReadLine()) != "Over")
            {
                int count = int.Parse(secondInput);

                string pattern = @"^([0-9]+)([a-zA-Z]{" + $"{count}" + @"})(" + "[^a-zA-Z]*" + ")$";       //@"^([0-9]+)([a-zA-Z]{"+count+"})([^a-zA-Z]*)$";

                if (!Regex.IsMatch(firstInput, pattern))
                {
                    continue;
                }

                Match matchCollection = Regex.Match(firstInput, pattern);
                string numbersFromBegin = matchCollection.Groups[1].Value;
                string message = matchCollection.Groups[2].Value;
                string afterMessage = matchCollection.Groups[3].Value;

                IEnumerable<int> numbersForCode = (numbersFromBegin + afterMessage)
                    .Where(Char.IsDigit)
                    .Select(s => s - '0');

                StringBuilder verificationCode = new StringBuilder();

                foreach (var index in numbersForCode)
                {
                    if (index >= 0 && index < message.Length)      // index is in range of the message
                    {

                        verificationCode.Append(message[index]);
                    }
                    else
                    {
                        verificationCode.Append(' ');
                    }
                }

                //  Console.WriteLine($"{message} == {verificationCode}");

                messages.Add(new Message(message, verificationCode.ToString()));




            }

            foreach (var mess in messages)
            {
                Console.WriteLine($"{mess.MessageText} == {mess.VerificationCode}");
            }
        }
    }

    public class Message
    {
        public Message(string messageText, string verificationCode)
        {
            this.MessageText = messageText;
            this.VerificationCode = verificationCode;
        }
        public string MessageText { get; set; }
        public string VerificationCode { get; set; }
    }
}
