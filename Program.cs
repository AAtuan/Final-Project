// Final project - Abel Atuan
//This is the firs part of my project. Its a search engine that will look for symptoms of medical conditions.
//The first part is a method that looks through the parts of an array looking for matches.
//first it will look for a match, then it will look for the next one and it will keep looking through the different variables trying to get a perfect match and then it will list the items with the similar or exact contents.
using System.Diagnostics;
class FinalProject
{

    static string Test(List<string> Symptoms, string [] Deseases)
    {

        List<string> Influenza = new List<string>();
        Influenza.Add("Headache");
        Influenza.Add("Cough");
        


        for (int i = 0; i < Symptoms.Count; i++)
        {
            for (int j = 0; i < Symptoms.Count; i++)
            {

            }
        }


    }
    static void Main()
    {
        string input = Console.ReadLine();
    }
}

// https://stackoverflow.com/questions/56978641/how-to-create-a-3d-list-in-c-sharp
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
//remember to implement dictionary lookup to simplify everything.

//Dictionary Lookup 
//https://stackoverflow.com/questions/5531042/how-to-find-item-in-dictionary-collection
//https://www.techiedelight.com/get-key-from-value-dictionary-csharp/