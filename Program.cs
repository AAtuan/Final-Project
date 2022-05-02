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

        cough.Add ("Cold");
        cough.Add ("Covid 19");
        cough.Add ("Flu");
        cough.Add ("Pneumonia");
        cough.Add ("Covid 19");

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

        Dictionary.Add("cough",cough);
        Dictionary.Add("headache", headache);
        Dictionary.Add("congestion",congestion);
        Dictionary.Add("sneezing",sneezing);
        Dictionary.Add("soreThrought",soreThrought);
        Dictionary.Add("bodyAche",bodyAche);

        List<string> userInput = new List<string>();

        Console.WriteLine("Please enter the amount of symptoms you are experiencing.");

        int symptomCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your symptoms");

        for (int i = 0; i < symptomCount; i++)
        {
            userInput.Add(Console.ReadLine());
        }

        foreach (var count in userInput)
        {
            Console.WriteLine(count);
        }

        // Console.WriteLine(userInput.Intersect<Dictionary>);

    }
}

// https://stackoverflow.com/questions/56978641/how-to-create-a-3d-list-in-c-sharp
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
//remember to implement dictionary lookup to simplify everything.

//Dictionary Lookup 
//https://stackoverflow.com/questions/5531042/how-to-find-item-in-dictionary-collection
//https://www.techiedelight.com/get-key-from-value-dictionary-csharp/