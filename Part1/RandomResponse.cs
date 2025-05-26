using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class RandomResponse
    {


       internal static void RandomResponses(string input)
        {
            if(input.Contains("phishing"))
            {
                List<string> RandomResponses = new List<string>
                {
                    "Check the Sender's Email Address",
                    "Avoid Clicking on Suspicious Links",
                    "Watch for Urgent or Threatening Language",
                    "Look for Generic Greetings",
                    "Check for Spelling and Grammar Errors",
                    "Don’t Download Unknown Attachments",
                    "Use Multi-Factor Authentication (MFA)",
                    "Keep Software Updated",
                };
                Random random = new Random();
                int index = random.Next(RandomResponses.Count);
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine(RandomResponses[index]);
            }

        }
    }
}
