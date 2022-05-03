// Final project - Abel Atuan
//This is the firs part of my project. Its a search engine that will look for symptoms of medical conditions.
//The first part is a method that looks through the parts of an array looking for matches.
//first it will look for a match, then it will look for the next one and it will keep looking through the different variables trying to get a perfect match and then it will list the items with the similar or exact contents.
using System.Diagnostics;
class FinalProject
{
    static void Main()
    {
        Dictionary<string, HashSet<string>> Dictionary = new Dictionary<string, HashSet<string>>();

        HashSet<string> cough = new HashSet<string>();
        HashSet<string> headache = new HashSet<string>();
        HashSet<string> congestion = new HashSet<string>();
        HashSet<string> sneezing = new HashSet<string>();
        HashSet<string> soreThrought = new HashSet<string>();
        HashSet<string> bodyAche = new HashSet<string>();

        // cough.Add ("Cold");

        Dictionary.Add("Cough", cough);
        Dictionary.Add("Headache", headache);
        Dictionary.Add("Congestion", congestion);
        Dictionary.Add("Sneezing", sneezing);
        Dictionary.Add("SoreThrought", soreThrought);
        Dictionary.Add("BodyAche", bodyAche);

        cough.Add ("Cold");
        cough.Add ("Covid 19");
        cough.Add ("Flu");
        cough.Add ("Pneumonia");

        headache.Add ("Sinusitis");
        headache.Add ("Cold");
        headache.Add ("Infections");
        headache.Add ("Dehydration");
        headache.Add ("Covid 19");

        congestion.Add ("Cold");
        congestion.Add ("Flu");
        congestion.Add ("Sinusitis");
        congestion.Add ("Infections");

        sneezing.Add ("Cold");
        sneezing.Add ("Influenza");
        sneezing.Add ("Sinusitis");

        soreThrought.Add ("Cold");
        soreThrought.Add ("Flu");
        soreThrought.Add ("Mono");
        soreThrought.Add ("Covid 19");

        bodyAche.Add ("Dehydration");
        bodyAche.Add ("Cold");
        bodyAche.Add ("Mono");
        bodyAche.Add ("Pneumonia");

        List<string> keyList = new List<string>(Dictionary.Keys);


        Console.WriteLine("Do you want to look for the illnesses related to a certain symptom or do you want to input 2 different symptoms and find the illnesses related to them?");
        Console.WriteLine("Enter a 1 if yes and a 2 if no");

        string yesorno = Console.ReadLine();

        if(yesorno == "1")
        {
            Console.WriteLine("The symptoms in our data base are:");
            foreach (var sublist in keyList)
            {
                Console.WriteLine(sublist);
            }
            Console.WriteLine();
            Console.WriteLine("Please enter the name of the symptom you are interested in");
            string conditional = Console.ReadLine();

            Console.WriteLine();

            foreach (var sublist in Dictionary[conditional])
            {
                Console.WriteLine(sublist);
            }
            Console.WriteLine("Those are the illnesses related to the symptom entered.");
        }
        else if(yesorno == "2")
        {
            Console.Clear();
            Console.WriteLine("The symptoms in our database are:");
            Console.WriteLine();

                foreach (var sublist in keyList)
                {
                    Console.WriteLine(sublist);
                }

                Console.WriteLine();

            Console.WriteLine("The program will output the illnesses related to those symptoms");
            Console.WriteLine("Please enter two your symptoms");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            Console.WriteLine();
            
            List<string> intersect = (Dictionary[input1].Intersect(Dictionary[input2])).ToList();

            Console.WriteLine("The illnesses registered in our database that you may have are:");
            Console.WriteLine();
            foreach (var sublist in intersect)
            {
                    Console.WriteLine(sublist);
            }
        }
    }
}
//The first two weren't used but were taken into consideration in my thought process throughout the project.
// https://stackoverflow.com/questions/56978641/how-to-create-a-3d-list-in-c-sharp
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
//remember to implement dictionary lookup to simplify everything.

//Dictionary Lookup 
//https://stackoverflow.com/questions/5531042/how-to-find-item-in-dictionary-collection
//https://www.techiedelight.com/get-key-from-value-dictionary-csharp/

//Dictionary Info
//https://www.tutorialsteacher.com/csharp/csharp-dictionary

//ToList() Info
//https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.tolist?view=net-6.0

//.Keys Info
//https://stackoverflow.com/questions/1276763/how-do-i-get-the-list-of-keys-in-a-dictionary