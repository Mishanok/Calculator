using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFirst
{
    public static class Manag
    {
        public static double First = 0;

        public static double Second = 0;

        public static string ind { get; set; }

        public static void Clear()
        {
            First = 0;
            Second = 0;
            ind = "";
        }
    }
}