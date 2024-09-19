using OOPproject1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int user_input;
            while (true)
            {
                Console.WriteLine(" 1.Add user \n 2.Update user \n 3.Delete user \n 4.Print all users");
                string string_input = Console.ReadLine();
                int.TryParse(string_input, out user_input);
                User user = new User();
                if (user_input == 1) { user.AddUser(users); }
                else if (user_input == 2) { user.UpdateUser(users); }
                else if (user_input == 3) { user.DeleteUser(users); }
                else if (user_input == 4) { user.PrintAllUsers(users); }
                else {
                    Console.WriteLine("Invalid Input X_X\n");
                }
                Console.WriteLine("Do you want to finish the program?   Y.Yes  N.No");
                char ans = char.Parse(Console.ReadLine());
                if(ans == 'Y' || ans == 'y') { Console.WriteLine("OK! Thank you ^_^"); break; }


            }
        }
    }

}
