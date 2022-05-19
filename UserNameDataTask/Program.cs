using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi;
            // programm küsib kasutajal sisestada number 1-3;
            // kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnmi tagurpidi;
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnmi pikkust;

            // eraldi funktsioonidese
            Console.WriteLine("Sisesta oma eesnimi: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Valige number: '1','2','3'");
            int useInput = Convert.ToInt32(Console.ReadLine());


            GetUsernameData(UserName);

        }
        public static void GetUsernameData(string userInput)

        {
            for (int i = userInput.Length - 1; i >= 0; i--) //tagurpidi
            {
                Console.Write(userInput[i]);
                break;
            }

            for (int i = userInput.Length - 1; i >= 0; i--)  //esimenetäht
            {
                Console.WriteLine($"Sinu eesnme esimene täht on {userInput[0]} ."); // esimene täht
                break;
            }
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");// pikkus
                break;
            }


        }


    }
}
