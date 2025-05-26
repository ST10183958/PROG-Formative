using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Part1
{
    internal class KeywoardDetection
    {

        // Delegate to handle keyword detection
        public delegate void KeywordDetectedDel(string inputString, int InputInt);

        // Event to trigger when a keyword is detected
        KeywordDetectedDel KeywordDetectedDetection = new KeywordDetectedDel(Detection);
        KeywordDetectedDel ResponceGeneratoin = new KeywordDetectedDel(RandomResponses);
        KeywordDetectedDel UserInterestDel = new KeywordDetectedDel(UserInterest);
        KeywordDetectedDel SentimentDel = new KeywordDetectedDel(SentimentResponse);


        // Method to handle keyword detection
        internal static void Detection(string inputString, int InputInt)
        {
            List<string> Keywords = new List<string> { "password", "scam", "privacy" };
            string keywordInUse;

            // Check if the input contains any of the keywords
            if (inputString.Contains(Keywords[0]))
            {
                keywordInUse = Keywords[0];
                Console.WriteLine($"Keyword recognized: {Keywords[0]}");
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine("Make sure to use strong password and do not share your password with anyone");
            }
            if (inputString.Contains(Keywords[1]))
            {
                keywordInUse = Keywords[1];
                Console.WriteLine($"Keyword recognized: {Keywords[1]}");
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine("There are many scams on the internet, Be wary of promises of quick money, free prizes, or guaranteed investment returns. These are classic red flags.");
            }
            if (inputString.Contains(Keywords[2]))
            {
  
                keywordInUse = Keywords[2];
                Console.WriteLine($"Keyword recognized: {Keywords[2]}");
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine("Privacy is very prudent for online use, Reusing the same password (or slight variations) across websites makes you incredibly vulnerable. If one site gets breached, hackers can use that password to access your other accounts—this is called credential stuffing.");
            }
        }
        // Method for random response generation
        internal static void RandomResponses(string inputString, int InputInt)
        {
            if (inputString.Contains("phishing"))
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
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine(RandomResponses[InputInt]);
            }
        }

        // Method for memory response generation
        internal static void RandomResponsesMemory(string inputString, int InputInt)
        {
            if (inputString.Contains("phishing"))
            {
                List<string> RandomResponsesMemory = new List<string>
                {
                    "Scammers often impersonate legitimate organizations by using email addresses that look similar to real ones,Spotting these small differences can help you avoid clicking on malicious links.",
                    "Suspicious links can lead to websites that automatically download malware onto your device — including viruses, spyware, or ransomware.",
                    "In phishing, you should watch for urgent or threatening language because it’s a common tactic used to manipulate you into acting quickly without thinking.",
                    "Trusted organizations you have accounts with (like your bank or Amazon) usually address you by your full name, not a vague greeting.",
                    "Professional organizations usually send well-written emails that are free of obvious mistakes. Frequent errors can indicate the sender is not who they claim to be.",
                    "Some attachments may secretly install software that steals your sensitive information.",
                    "You should use Multi-Factor Authentication (MFA) because it adds a critical extra layer of security to your accounts.",
                    "You should keep your software updated to protect your devices and data from security vulnerabilities and bugs."
                };
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine(RandomResponsesMemory[InputInt]);
            }

        }

        // Method to handle user interest
        internal static void UserInterest(string inputString, int InputInt)
        {
            // Memory response for user interest related to scams
            if (inputString == "scams")
            {
                Random random = new Random();
                int indexVal = random.Next(1, 7);
                List<string> RandomResponsesMemory = new List<string>
                {
                    "Verify Before You Trust: If someone contacts you unexpectedly asking for personal info, money, or access to your devices (via email, phone, or text), always verify their identity through official channels. Never click links or download attachments from unknown sources.",
                    "Watch for Red Flags: Scammers often create urgency (“Act now or lose everything!”), use poor grammar, or make offers that seem too good to be true. If it feels off, it probably is.",
                    "Protect Your Personal Info: Don’t share sensitive details (like your Social Security number, bank info, or passwords) unless you’re absolutely sure who you’re dealing with and why they need it. Use strong, unique passwords and enable two-factor authentication wherever possible.",
                };
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine($"Since you are interested in {inputString}");
                Console.WriteLine(RandomResponsesMemory[InputInt]);

            }
            // Memory response for user interest related to DDOS
            if (inputString == "ddos")
            {
                Random random = new Random();
                int indexVal = random.Next(1, 7);
                List<string> RandomResponsesMemory = new List<string>
                {
                    "Use a Content Delivery Network (CDN): CDNs can absorb and mitigate DDoS attacks by distributing traffic across multiple servers, making it harder for attackers to overwhelm a single target.",
                    "Implement Rate Limiting: Set limits on the number of requests a user can make in a given time frame. This helps prevent overwhelming your server with too many requests at once.",
                    "Monitor Traffic Patterns: Use network monitoring tools to detect unusual spikes in traffic that may indicate a DDoS attack. Early detection can help you respond quickly and minimize damage."
                };

                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine($"Since you are interested in {inputString}");
                Console.WriteLine(RandomResponsesMemory[InputInt]);
            }
            // Memory response for user interest related to malware
            if (inputString == "malware")
            {
                Random random = new Random();
                int indexVal = random.Next(1, 7);
                List<string> RandomResponsesMemory = new List<string>
                {
                    "Use Antivirus Software: Install reputable antivirus software on your devices and keep it updated. Regularly scan your system for malware and remove any threats.",
                    "Be Cautious with Downloads: Only download software from trusted sources. Avoid clicking on pop-up ads or links in emails that promise free downloads, as they may contain malware.",
                    "Keep Your Software Updated: Regularly update your operating system, applications, and security software to patch vulnerabilities that malware can exploit."
                };
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine($"Since you are interested in {inputString}");
                Console.WriteLine(RandomResponsesMemory[InputInt]);
            }
            // Memory response for user interest related to trojan
            if (inputString == "trojan")
            {
                Random random = new Random();
                int indexVal = random.Next(1, 7);
                List<string> RandomResponsesMemory = new List<string>
                {
                    "Use Antivirus Software: Install reputable antivirus software that can detect and remove Trojans. Keep it updated to ensure it can recognize the latest threats.",
                    "Be Wary of Email Attachments: Avoid opening email attachments from unknown senders or unexpected emails from known contacts. Trojans often disguise themselves as harmless files.",
                    "Keep Your System Updated: Regularly update your operating system and software to patch vulnerabilities that Trojans can exploit."
                };
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine($"Since you are interested in {inputString}");
                Console.WriteLine(RandomResponsesMemory[InputInt]);
            }
        }

        // Sentiment response method
        internal static void SentimentResponse(string inputString, int InputInt)
        {
            string sentiment = null;
            if (inputString.Contains("worried"))
            {
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine("It's normal to feel worried about online safety. Remember, being cautious and informed is the first step to protecting yourself.");
            }
            if (inputString.Contains("fustrated"))
            {
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine("I understand that it can be frustrating. Let's work together to find solutions and improve your online safety.");
            }
            if (inputString.Contains("curious"))
            {
                Welcome.ChatBotDraw("Chatbot:");
                Console.WriteLine("Curiosity is great! It shows you're eager to learn and improve your online safety. What would you like to know more about?");    
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                    