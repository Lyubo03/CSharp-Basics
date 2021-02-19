using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Going
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialize 
            Console.WriteLine("Type some kind of practise. (It can be everything that comes to your mind)");
            string course = Console.ReadLine();
            Console.WriteLine("Enter some kind of noun");
            string poster = Console.ReadLine();
            Console.WriteLine("Type some an adjective");
            string firstAdj = Console.ReadLine();
            Console.WriteLine("Write an activity in past tense");
            string adjPast = Console.ReadLine();
            Console.WriteLine("Write a verb in past tense");
            string firstVerb = Console.ReadLine();
            Console.WriteLine("Write some kind of fruit");
            string fruit = Console.ReadLine();
            Console.WriteLine("Write some kind of funny activity");
            string funnyAct = Console.ReadLine();
            Console.WriteLine("Write something that you can learn");
            string learn = Console.ReadLine();
            Console.WriteLine("Write one more thing you can learn");
            string learnTwo = Console.ReadLine();
            Console.WriteLine("Some kind of animal");
            string animal = Console.ReadLine();
            Console.WriteLine("Write a noun");
            string final = Console.ReadLine();
            Console.Clear();
            string quote =
                "Reed College at that time offered perhaps the best " + course + " course in the country." +
                "Throughout the campus every " + poster +", every label on every drawer, was" +firstAdj + "hand " +adjPast  +'.' +
                "Because I had" + firstVerb + " out and didn’t have to take the" + fruit + " classes, I decided to take a/an " 
                + course + " class to learn how to" + funnyAct + '.' +
                " I learned about " + learn + " and " + learnTwo +", about varying the amount of space" +
                " between different letter combinations, about what makes great" + animal + " great." +
                " It was beautiful, historical, artistically subtle in a way that " + final
                + " can’t capture, and I found it fascinating.";
            //print it
            Console.WriteLine(quote);
        }
    }
}
