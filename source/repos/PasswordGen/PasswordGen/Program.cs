using System;
using System.IO;
using System.Text;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Key variables.
            string passwordHint = "";
            string password = "";
            string passGenerate = "";

            Console.WriteLine("Enter a hint for the password, Facebook, Reddit, Bank");

            //Input.
            passwordHint = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Password has been generated.");

            StringBuilder s = new StringBuilder();

            //Characters in the password.
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789#%&*".ToCharArray();
            
            Random r = new Random();

            //Add characters to password.
            for (int i = 0; i < r.Next(20, 30); i++)
            {
                //Choose a random char.
                var addChar = alphabet[r.Next(0, alphabet.Length)];
                int randNum = r.Next(0, 6);

                if (randNum == 3)
                {
                    addChar = Char.ToUpper(addChar);
                    s.Append(addChar);

                }
                else
                {
                    addChar = Char.ToLower(addChar);
                    s.Append(addChar);
                }

            }
            passGenerate = s.ToString();
            password = passwordHint + ": " + passGenerate;
            
            Console.WriteLine(password);

            try
            {
                FileStream fs = new FileStream(@"C:\Users\Alvin\Desktop\p4ssw4rds.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(fs);

                writer.WriteLine($"{password}");
                writer.WriteLine($"");
                writer.WriteLine($"Password created: {DateTime.Now}");
                writer.WriteLine("---------");

                writer.Close();
                fs.Close();

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();






        }
    }
}
