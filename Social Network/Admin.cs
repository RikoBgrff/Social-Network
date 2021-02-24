using Social_Network.PostNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.AdminNamespace
{
    
    class Admin :Instance
    {
        public Post[] PostsOfAdmin { get; set; }
        public Notification[] NotificationsOfAdmin { get; set; }
        public int NotificationCount { get; set; } = 0;
        public void AddNotification(ref Notification notification)
        {
            Notification[] temp = new Notification[++NotificationCount];
            if (NotificationsOfAdmin != null)
            {
                NotificationsOfAdmin.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = notification;
            NotificationsOfAdmin = temp;
        }
        public void showNotifications()
        {
            foreach (var item in NotificationsOfAdmin)
            {
                Console.WriteLine(item.Text);
            }
        }
        public int PostCount { get; set; } = 0;
        public void AddPost(ref Post post)
        {
            Post[] temp = new Post[++PostCount];
            if (PostsOfAdmin != null)
            {
                PostsOfAdmin.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = post;
            PostsOfAdmin = temp;
        }

    }
}
