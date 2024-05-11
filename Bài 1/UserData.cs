using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public static class UserData
    {
        public static string ID;
        public static string Name;
        public static float Health;
        public static int Point;

        static UserData()
        {
            ID = "3107";
            Name = "abcdxyznmasad:))";
            Health = 100.5f;
            Point = 100;
        }
    }
}