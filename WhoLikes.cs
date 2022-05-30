using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class WhoLikes
    {
        public static string Likes(string[] name)
        {
            int likes = name.Length;

            switch (likes)
            {
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                case >= 4:
                    return $"{name[0]}, {name[1]} and {likes - 2} others like this";
                default:
                    return "no one likes this";
            }
        }
    }
}
