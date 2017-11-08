using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02_HornetComm
{
   public class StartUp
    {
        public static void Main()
        {
            List<Message>messages=new List<Message>();
            List<Message>broadcasts=new List<Message>();
            
            string input;

            while ((input=Console.ReadLine())!= "Hornet is Green")
            {
                if(!input.Contains("<->"))continue;
                
                string paternMessage= @"^([\d]+) <-> ([\da-zA-Z]+)$";
                string patternBroadcast = @"^([^\d]+) <-> ([\da-zA-Z]+)$";
                
                if(!Regex.IsMatch(input,paternMessage)&&!Regex.IsMatch(input,patternBroadcast))continue;

                if (Regex.IsMatch(input,paternMessage))
                {
                    var messageMatchColetion = Regex.Matches(input, paternMessage);
                    string recepient="";
                    string messageText="";
                    foreach (Match m in messageMatchColetion)
                    {
                        recepient = m.Groups[1].Value;
                        messageText = m.Groups[2].Value;
                       

                    }
                    string finalRecepient=String.Join("", recepient.ToCharArray().Reverse());
                    Message message=new Message(finalRecepient,messageText);
                    messages.Add(message);
                }

                if (Regex.IsMatch(input, patternBroadcast))
                {
                    var broadcastCollection = Regex.Matches(input, patternBroadcast);
                    string frequence = "";
                    string messageText = "";
                    foreach (Match m in broadcastCollection)
                    {
                        messageText = m.Groups[1].Value;
                        frequence = m.Groups[2].Value;
                    }

                    string finalFrequence = ChangeLowerToUpperAndOpposit(frequence);
                    Message broadcast=new Message(finalFrequence,messageText);
                    broadcasts.Add(broadcast);

                }
                

            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var br in broadcasts)
                {
                    Console.WriteLine($"{br.FreqOrRecepient} -> {br.MessageText}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var mess in messages)
                {
                    Console.WriteLine($"{mess.FreqOrRecepient} -> {mess.MessageText}");
                }
            }
        }
        
        public static string ChangeLowerToUpperAndOpposit(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]>=97&&str[i]<=122)
                {
                    result+= (char)((str[i]) - 32);
                }
                else if(str[i] >= 65 && str[i] <= 90)
                {
                    result+= (char)((str[i]) + 32);
                }
                else
                {
                    result += str[i];
                }
                
            }
            return result;
        }
        
    }

    public class Message
    {
        public Message(string freqOrRecepient, string messageText)
        {
            this.FreqOrRecepient = freqOrRecepient;
            this.MessageText = messageText;
        }
        
        public string FreqOrRecepient { get; set; }
        public string MessageText { get; set; }
    }
}
