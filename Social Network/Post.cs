using Social_Network.AdminNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.PostNamespace
{
    class Post : Instance
    {
        public string Content { get; set; }
        public string CreationTime { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        public void Like()
        {
            LikeCount = LikeCount + 1;
        }
        public void ShowPost()
        {
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Content:{Content}");
            Console.WriteLine($"Creation Time:{CreationTime}");
            Console.WriteLine($"Like Count:{LikeCount}");
            Console.WriteLine($"View Count:{ViewCount}");
            Console.WriteLine("");
        }
    }
}
