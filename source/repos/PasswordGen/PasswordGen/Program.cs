using System;
using System.Text;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Key variables
            string passwordHint = "";
            string password = "";
            string passGenerate = "";

            //Input
            Console.WriteLine("Enter a hint for the password, Facebook, Reddit, Bank");
            passwordHint = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Password has been generated.");
            Console.WriteLine("Tests");
            Console.WriteLine("t");

            StringBuilder s = new StringBuilder();


            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789#%&*".ToCharArray();

            Random r = new Random();

            for (int i = 0; i < r.Next(20, 30); i++)
            {
                var charResult = alphabet[r.Next(0, alphabet.Length)];

                Random rs = new Random();
                int rst = rs.Next(0, 6);


                if (rst == 3)
                {
                    charResult = Char.ToUpper(charResult);
                    s.Append(charResult);

                }
                else
                {
                    charResult = Char.ToLower(charResult);
                    s.Append(charResult);
                }

            }

            passGenerate = s.ToString();
            password = passwordHint + ": " + passGenerate;

            Console.WriteLine(password);
            Console.ReadKey();






        }
    }
}
