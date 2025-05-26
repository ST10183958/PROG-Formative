using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Part2
    {
       internal static void Part2Main()
        {
            List<string> Keywords = new List<string> { "password", "scam", "privacy" };
            List<string> Interests = new List<string> { "scams", "ddos", "malware", "trojan" };
            string PreviousInput = null;
            string PreviousUserInput = null;
            int PreviousInputInt = 0;
            string UserInterestIn = null;

            while (true)
            {



                Console.Write("User:");
                var UserInput = Console.ReadLine();

                if (UserInput.Contains("password") || UserInput.Contains("scam") || UserInput.Contains("privacy"))
                {
                    KeywoardDetection.Detection(UserInput, 0);
                }
                if (UserInput.Contains("phishing") && !UserInput.Contains("interested"))
                {
                    Random random = new Random();
                    int indexVal = random.Next(1, 7);
                    PreviousInputInt = indexVal;
                    
                    KeywoardDetection.RandomResponses(UserInput, indexVal);
                    PreviousInput = "phishing";
                } else {
                    //ErrorDisplay();
                }

                //Memory response 
                if (PreviousInput == "phishing" && UserInput.Contains("explain"))
                {
                    KeywoardDetection.RandomResponsesMemory(PreviousInput, PreviousInputInt);
                }

                //sentiment analysis
                if (UserInput.Contains("worried") || UserInput.Contains("curious") || UserInput.Contains("fustrated") )
                {
                    KeywoardDetection.SentimentResponse(UserInput,0);
                }

                //detects if user inputs favourite topic 
                if (UserInput.Contains("interested"))
                {
                    string[] splitInput = UserInput.Split(' ');
                    // UserInterestIn = splitInput[3];
                    // Check if the user input contains a keyword
                    if (Interests.Contains(splitInput[3]))
                    {
                        UserInterestIn = splitInput[3];
                        Welcome.ChatBotDraw("Chatbot:");
                        Console.WriteLine($"Thanks I will remember that your interested in {UserInterestIn}.");
                    }
                    else
                    {
                        Console.WriteLine("Your interested must be related to cybersecurity");
                    }
                }
                if (UserInput.Contains("give") && UserInput.Contains("tip"))
                {
                    Console.WriteLine($"I can give you tips on phishing, malware, and trojan. {UserInterestIn}");
                    KeywoardDetection.UserInterest(UserInterestIn, 0);
                } 
                if (!IsString(UserInput)) {
                    Welcome.ChatBotDraw("Chatbot:");
                    Console.WriteLine("I did not understand your question, please rephrase it.");
                }

                
            }
        }

       internal static void ErrorDisplay()
        {
            Welcome.ChatBotDraw("I did not understand your question, may you please rephrase it.");
        }

        static bool IsString(object input)
        {
            return input is string;
        }
    }
}
