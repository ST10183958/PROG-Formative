using System.Threading;
using System.Media;
using Part1;


namespace FormativePROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome.ShowWelcomeScreen();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Audio\ElevenLabs_Text_to_Speech_audio.mp3");
            //player.Play();

            object Username = UsernameInput();

            Welcome.DrawBorder2($"Greetinngs {Username}");

            Responses();
            Console.WriteLine("Finished");
        }


        // Method to handle user input for username
        static string UsernameInput()
        {

            while (true)
            {

                String name;

                Console.Write("Enter your name:");

                name = Console.ReadLine();

                try
                {

                    if (string.IsNullOrWhiteSpace(name))
                    {

                        throw new InvalidCastException("Username is empty");

                    }
                    else
                    {

                        return name;

                    }



                }
                catch (Exception e)
                {

                    Welcome.ErrorDraw($"Error: {e}");

                }

            }

        }


        static void Responses()
        {



            while (true)
            {

                try
                {

                    Console.Write("Enter input:");

                    String UserResponse = Console.ReadLine();

                    Delayer();



                    if (Convert.ToString(UserResponse) == "How are you?")
                    {

                        Welcome.DrawBorder2("I am Great thank you");

                    }

                    else if (Convert.ToString(UserResponse) == "What's your purpose?")
                    {

                        Welcome.DrawBorder2("Im here to provide information about cybersecurity safety.");

                    }

                    else if (Convert.ToString(UserResponse) == "What can i ask you about?")
                    {

                        Welcome.DrawBorder2("You can ask me about anything related to cybersecurity safety. Example i can provide information about what phishing attacks are and how to browse the internet in a safe manner");

                    }

                    // Cybersecurity related questions 
                    else if (Convert.ToString(UserResponse) == "What is phishing?")
                    {

                        Welcome.DrawBorder2("Phishing is a cybercrime where attackers deceive individuals into revealing sensitive information. It can be done through fraudulent emails, text messages, phone calls, or websites. The goal is to steal data such as passwords, credit card details, and personally identifiable information.");

                    }
                    else if (Convert.ToString(UserResponse) == "What is DDOS?")
                    {

                        Welcome.DrawBorder2("A Distributed Denial-of-Service (DDoS) attack is a malicious attempt to disrupt the normal traffic of a targeted server, service, or network by overwhelming it with a flood of Internet traffic. This is achieved by utilizing multiple compromised computer systems as sources of attack traffic");

                    }
                    else if (Convert.ToString(UserResponse) == "How to have safe browsing?")
                    {

                        Welcome.DrawBorder2("When browsing the web always make sure the sites you browse are trusted");

                    }

                    else
                    {

                        throw new InvalidCastException("I didn't quite understand that. Could you rephrase");

                    }

                }
                catch (Exception e)
                {

                    Welcome.ErrorDraw("Error: " + e.Message);

                }



            }







        }



        static void Delayer()
        {

            for (int looper = 0; looper < 4; looper++)
            {

                Thread.Sleep(800);

                Console.Write('*');

                continue;

            }

            Console.WriteLine("--------------");



        }



    }
}
