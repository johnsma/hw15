using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The AI bots started out in a lab, the AI bots escaped from the lab, and now are in a town near you!");
            Console.ReadKey();

            Console.WriteLine("They have turned into an AI bot Team.");
            Console.ReadKey();

            Console.WriteLine("The AI bots fight crime and help the humans create great things for all.");
            Console.ReadKey();

            Console.WriteLine("The AI bots run into a girl who ask what are you?");
            Console.ReadKey();

            Console.WriteLine("One AI bot responds with we are AI bots here to help the humans.");
            Console.ReadKey();

            Console.WriteLine("The girl ask that is very nice of you.");
            Console.ReadKey();

            Console.Write("The AI bot responds with you are a good person... [What is your name new AI bot member:]");
            string AIbotName = Console.ReadLine();

            AIbot storyAIbot = new AIbot(AIbotName, 301);
            
                
                                    
            Console.WriteLine("{0} being as an AI bot human assist member means we can transform into a vehicle for you with a maximum speed of {1}", AIbotName, storyAIbot._Strength);
            Console.ReadKey();
        }
    }
}         



            
     