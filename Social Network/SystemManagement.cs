using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_Network.AdminNamespace;
using Social_Network.UserNamespace;
using Social_Network.PostNamespace;
using System.Threading;

namespace Social_Network
{
    class SystemManagement
    {

        Admin admin = new Admin()

        {
            Email = "riko.bagirli777@gmail.com",
            Username = "rikobgrff",
            Password = "ejdaha",
        };
        User user = new User
        {
            Username = "rikobgrff",
            Name = "Riko",
            Surname = "Bgrff",
            Age = 18,
            Email = "rikobgrff.17@gmail.com",
            Password = "riko1234"

        };
        static List<Post> posts = new List<Post>();
        static Post post1 = new Post
        {
            Content = "Photo1.png",
            CreationTime = "5 days ago",
            LikeCount = 5,
            ViewCount = 3,
            ID = Guid.NewGuid()
        };
        static Post post2 = new Post
        {
            Content = "Photo6.png",
            CreationTime = "36 min ago",
            LikeCount = 27,
            ViewCount = 30,
            ID = Guid.NewGuid()
        };
        static Post post3 = new Post
        {
            Content = "Photo2.png",
            CreationTime = "31 Jan",
            LikeCount = 14,
            ViewCount = 16,
            ID = Guid.NewGuid()
        };
        static Post post4 = new Post
        {
            Content = "Photo3.png",
            CreationTime = "a week ago",
            LikeCount = 40,
            ViewCount = 45,
            ID = Guid.NewGuid()
        };
        static Post post5 = new Post
        {
            Content = "Photo4.png",
            CreationTime = "2 Feb",
            LikeCount = 55,
            ViewCount = 66,
            ID = Guid.NewGuid()
        };
        static Post post6 = new Post
        {
            Content = "Photo5.png",
            CreationTime = "31 December 2020",
            LikeCount = 150,
            ViewCount = 190,
            ID = Guid.NewGuid()
        };
        public static void FillList()
        {
            posts.Add(post1);
            posts.Add(post2);
            posts.Add(post3);
            posts.Add(post4);
            posts.Add(post5);
            posts.Add(post6);
        }

        public void Login()
        {
            Console.WriteLine("Admin:0");
            Console.WriteLine("User:1");
            Console.Write("Your Choice:");
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                Console.Write("Username or email:");
                string usernameOrEmail = Console.ReadLine();
                CheckAdminUsername(usernameOrEmail, admin);
                if (CheckAdminUsername(usernameOrEmail, admin) == true)
                {
                    Console.Write("Password:");
                    string password = Console.ReadLine();
                    CheckAdminPassword(password, admin);
                    if (CheckAdminPassword(password, admin) == true)
                    {
                        Console.WriteLine("Logged sucssessfully");
                    }
                    if (CheckAdminPassword(password, admin) == false)
                    {
                        Console.WriteLine("Wrong Password");
                    }
                }
                if (CheckAdminUsername(usernameOrEmail, admin) == false)
                {
                    Console.WriteLine("Cannot Find User");
                }
            }
            if (choice == "1")
            {
                Console.Write("Username or email:");
                string usernameOrEmail = Console.ReadLine();
                CheckAdminUsername(usernameOrEmail, admin);
                if (CheckUserUsername(usernameOrEmail, user) == true)
                {
                    Console.Write("Password:");
                    string password = Console.ReadLine();
                    CheckUserPassword(password, user);
                    if (CheckUserPassword(password, user) == true)
                    {
                        FillList();
                        Console.WriteLine("Logged Sucsessfully");
                        Thread.Sleep(2000);
                        Console.Clear();
                        posts.ForEach(p => p.ShowPost());
                        Console.WriteLine("Like Post:1");
                        Console.WriteLine("Show Photo:2");
                        string likeOrShow = Console.ReadLine();
                        if (likeOrShow == "1")
                        {
                            Notification photoLiked = new Notification()
                            {
                                NotificationTime = DateTime.Now,
                                Text = "User liked photo",
                            };
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.Write("Enter ID:");
                            string forId = Console.ReadLine();
                            foreach (var item in posts)
                            {
                                if (item.ID.ToString() == forId)
                                {
                                    item.ShowPost();
                                    item.Like();
                                    Console.WriteLine($"Likes:{item.LikeCount}");
                                    admin.AddNotification(ref photoLiked);
                                }
                            }

                        }
                        if (likeOrShow == "2")
                        {
                            Notification photoHasSeen = new Notification()
                            {
                                NotificationTime = DateTime.Now,
                                Text = "Photo has seen by user"
                            };
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.Write("Enter ID:");
                            string forId = Console.ReadLine();

                            foreach (var item in posts)
                            {
                                item.ShowPost();
                            }
                            admin.AddNotification(ref photoHasSeen);

                        }
                    }
                    if (CheckUserPassword(password, user) == false)
                    {
                        Console.WriteLine("Wrong Password");
                    }
                }
                if (CheckUserUsername(usernameOrEmail, user) == false)
                {
                    Console.WriteLine("Cannot Find User");
                }
            }
        }
        public bool CheckAdminUsername(string data, Admin admin)
        {
            if (admin.Username == data || admin.Email == data)
            {
                return true;
            }
            return false;
        }
        public bool CheckAdminPassword(string data, Admin admin)
        {
            if (admin.Password == data || admin.Password == data)
            {
                return true;
            }
            return false;
        }
        public bool CheckUserUsername(string data, User user)
        {
            if (user.Username == data || user.Email == data)
            {
                return true;
            }
            return false;
        }
        public bool CheckUserPassword(string data, User user)
        {
            if (user.Password == data || user.Password == data)
            {
                return true;
            }
            return false;
        }

    }
}
