using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Management_Database
{
    public static class Mother
    {
        public static int hospitalId = 1;
        public static int get() { return hospitalId; }
        public static void set(int a) { hospitalId = a; }
    }
}