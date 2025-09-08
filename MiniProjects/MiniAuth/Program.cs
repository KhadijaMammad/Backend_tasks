using System;
using System.Runtime.InteropServices;

namespace SimpleAuthProgram
{
    class User
    {
        public string Usernname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public User(string userName, string email, string password, string role)
        {
            Usernname = userName;
            Email = email;
            Password = password;
            Role = role;
        }
    }
    class Teacher : User
    {
        public Teacher(string userName, string email, string password) : base(userName, email, password, "Teacher") { }
    }
    class Student : User
    {
        public Student(string userName, string email, string password) : base(userName, email, password, "Student") { }
    }

    class Program
    {
        static User[] users = new User[10];
        static int userCount = 0;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1 - Register");
                Console.WriteLine("2 - Login");
                Console.WriteLine("3 - Exit");
                Console.Write("Choose an option:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;

                    case "2":
                        Login();
                        break;

                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
            static void Register()
            {
                if (userCount >= users.Length)
                {
                    Console.WriteLine("User limit reached. Cannot register more users.");
                    return;
                }
                Console.Write("User name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("password: ");
                string password = Console.ReadLine();

                Console.Write("Choose the role (1 - Teacher, 2 - Student): ");
                string roleChoice = Console.ReadLine();

                if (roleChoice == "1")
                {
                    users[userCount] = new Teacher(name, email, password);
                }
                else if (roleChoice == "2")
                {
                    users[userCount] = new Student(name, email, password);
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    return;
                }

                Console.WriteLine("Qeydiyyat uğurla tamamlandı!");
                userCount++;
            }

            static void Login()
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < userCount; i++)
                {
                    if (users[i].Email == email && users[i].Password == password)
                    {
                        Console.WriteLine($"Welcome, {users[i].Usernname}! You are logged in as a {users[i].Role}.");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Invalid email or password.");
                }
            }
        }
    }
}