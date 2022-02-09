using System;
using System.IO;
using System.Text.Json;

namespace Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant e = new Etudiant("Ahmed");
            e.ajouterAmie(new Etudiant("chaimae"));
            e.ajouterAmie(new Etudiant("ghita"));
            e.ajouterAmie(new Etudiant("mourad"));

            //sérialisation => Console 
            Console.WriteLine("\nSérialisation\n");
            Console.WriteLine(JsonSerializer.Serialize(e));

            //sérialisation => dans un fihier etudiants.json 
            Console.WriteLine("\nSérialisation dans le fichier\n");
            File.WriteAllText("etudiants.json", JsonSerializer.Serialize(e));


            //désérialisation
            Console.WriteLine("\ndéserialisation\n");

            Etudiant es = JsonSerializer.Deserialize<Etudiant>(File.ReadAllText("etudiants.json"));
            Console.WriteLine(es.ToString());

            Console.WriteLine("\nfin\n");
            Console.ReadKey();
        }
    }
}



