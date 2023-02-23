using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Main();

        void Main()
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            CanadaQuestion();
            EnthusiasticQuestion();
            LoveCSharpQuestion();
            SecretQuestion();
            DumbFortune();
        };



        void MooseSays(string message)
        {
            Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
        };


        bool MooseAsks(string question)
        {
            string answer = "";
            /* Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower(); */

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        };


        void CanadaQuestion()
        {
            bool isTrue = MooseAsks("Is Canada real?");
            if (isTrue)
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else
            {
                MooseSays("I  K N E W  I T !!!");
            }
        };

        void EnthusiasticQuestion()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSays("Yay!");
            }
            else
            {
                MooseSays("You should try it!");
            }
        };

        void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
        };

        void SecretQuestion()
        {
            bool wantsSecret = MooseAsks("Do you want to know a secret?");
            if (wantsSecret)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
        };

        /* void DumbFortune()
        {
            Random r = new Random();
            Dictionary<int, string> fortune = new Dictionary<int, string>() 
            {
                {1, "As I see it, yes."}, 
                {2, "Ask again later."}, 
                {3, "Better not tell you now."}, 
                {4, "Cannot predict now."}, 
                {5, "Concentrate and ask again."}, 
                {6, "Don’t count on it."}, 
                {7, "It is certain."}, 
                {8, "It is decidedly so."}, 
                {9, "Most likely."}, 
                {10, "My reply is no."}, 
                {11, "My sources say no."}, 
                {12, "Outlook not so good."}, 
                {13, "Outlook good."}, 
                {14, "Reply hazy, try again."}, 
                {15, "Signs point to yes."}, 
                {16, "Very doubtful."}, 
                {17, "Without a doubt."}, 
                {18, "Yes."}, 
                {19, "Yes – definitely."}, 
                {20, "You may rely on it."}
            };

            for (int i = 0; i < 10; ++i)
            {
                int index = r.Next(fortune.Count);
                KeyValuePair<int, string> pair = 
            }




            /* string genRand = r. ("As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it.");
            Console.WriteLine("Random Number = " + genRand);
        }; */
    }
}