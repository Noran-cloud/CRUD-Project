using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject1.Properties
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public void AddUser(List<User> users)
        {
            Console.WriteLine("**********Add User**********");
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Enter ID");
            string id = Console.ReadLine();

            User user = new User();
            user.Name = name;
            user.Email = email;
            user.ID = id;

            users.Add(user);

            Console.WriteLine("Successful process");
            Console.WriteLine("*******************************");
        }
        public void UpdateUser(List<User> users)
        {
            Console.WriteLine("********** Update User **********");
            Console.WriteLine("Enter ID of user you wanna update");
            string id = Console.ReadLine();
            User founduser = users.FirstOrDefault(x => x.ID == id);
            bool found = false;
            if (founduser != null)
            {
                Console.WriteLine("Enter new name :");
                string newname = Console.ReadLine();
                Console.WriteLine("Enter new email :");
                string newemail = Console.ReadLine();
                Console.WriteLine("Enter new ID :");
                string newid = Console.ReadLine();
                founduser.Name = newname;
                founduser.Email = newemail;
                founduser.ID = newid;

                Console.WriteLine("Successful process");
                Console.WriteLine("*******************************");
            }
            else { 
                Console.WriteLine("not valid...");
            }
        }
        public void DeleteUser(List<User> users)
        {
            Console.WriteLine("********** Delete user **********");
            Console.WriteLine("Enter ID of user you wanna delete");
            string id = Console.ReadLine();
            User foundeuser = users.FirstOrDefault(x => x.ID == id);
            if (foundeuser != null)
            {
                users.Remove(foundeuser);
                Console.WriteLine("Successful process");
            }
            else { Console.WriteLine("not valid"); }
        }
        public void PrintAllUsers(List<User> users)
        {
            Console.WriteLine("********** Print All Users **********");
            int cnt = 1;
            foreach (User user in users)
            {
                Console.WriteLine(cnt+".");
                Console.WriteLine("Name : "+user.Name);
                Console.WriteLine("Email :"+user.Email);
                Console.WriteLine("Password : "+user.ID);
                cnt++;

            }
            Console.WriteLine("*******************************");
        }
    }
}
