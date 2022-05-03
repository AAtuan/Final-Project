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

        Dictionary.Add("cough", cough);
        Dictionary.Add("headache", headache);
        Dictionary.Add("congestion", congestion);
        Dictionary.Add("sneezing", sneezing);
        Dictionary.Add("soreThrought", soreThrought);
        Dictionary.Add("bodyAche", bodyAche);

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

        // Dictionary.Add("cough",cough);
        // Dictionary.Add("headache", headache);
        // Dictionary.Add("congestion",congestion);
        // Dictionary.Add("sneezing",sneezing);
        // Dictionary.Add("soreThrought",soreThrought);
        // Dictionary.Add("bodyAche",bodyAche);


        // int symptomCount = int.Parse(Console.ReadLine());
        

        Console.WriteLine("Please enter two your symptoms");
        Console.WriteLine("The program will output the illnesses related to those symptoms");

        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        // Dictionary.Intersect(input1).Intersect(input2);


        // HashSet<HashSet<string>> ListofLists = new HashSet<HashSet<string>>() {cough, headache,congestion,soreThrought,sneezing,bodyAche};

        // List<List<>> intersect = new List<List<>>(){userInput.Intersect(Illnesses).ToList()};

        // ListofLists.IntersectWith(userInput);
        Dictionary[input1].Intersect(Dictionary[input2]);
        // Console.WriteLine(Dictionary[input1]);
        
        List<string> intersect = (Dictionary[input1].Intersect(Dictionary[input2])).ToList();

        foreach (var sublist in intersect)
        {
            // foreach (var obj in sublist)
            // {
                Console.WriteLine(sublist);
            // }
        }
        // Console.WriteLine(Dictionary[input2]);

        // foreach (var count in (ListofLists))
        // {
        //     Console.WriteLine(count);   
        // }


    }
}

// https://stackoverflow.com/questions/56978641/how-to-create-a-3d-list-in-c-sharp
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
//remember to implement dictionary lookup to simplify everything.

//Dictionary Lookup 
//https://stackoverflow.com/questions/5531042/how-to-find-item-in-dictionary-collection
//https://www.techiedelight.com/get-key-from-value-dictionary-csharp/