using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_HandsOfCards
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> handsOfCard = new Dictionary<string, string>();
            
            Dictionary<char, int> cardsPower = new Dictionary<char, int>
            {
                {'2',2 },
                {'3',3 },
                {'4',4 },
                {'5',5 },       //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A   
                {'6',6 },
                {'7',7 },
                {'8',8 },
                {'9',9 },
                {'1',10},
                {'J',11 },
                {'Q',12 },
                {'K',13 },
                {'A',14 }
            };

            Dictionary<char, int> cardsType = new Dictionary<char, int>
            {
                {'S',4},
                {'H',3},        //S, H, D, C
                {'D',2},
                {'C',1}
            };

            string input;

            while ((input=Console.ReadLine())!= "JOKER")
            {
                var arr = input.Split(new[] {":"}, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    handsOfCard.Add(arr[0],arr[1]);
                }
                catch (Exception e)
                {
                    handsOfCard[arr[0]] += arr[1];
                }
                
               
            }

            foreach (var pair in handsOfCard)
            {
                var cards = pair.Value.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                int sum = 0;

                foreach (var card in cards)
                {
                    if (card.Length < 3)
                    {
                        sum += cardsPower[card[0]] * cardsType[card[1]];
                    }
                    else
                    {
                        sum += cardsPower[card[0]] * cardsType[card[2]];
                    }

                }

                Console.WriteLine($"{pair.Key}: {sum}");
            }
           
        }
    }
}
