using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyQuanAn
{
    public static class Global
    {
        public static string GlobalUserID { get; private set; }
        public static void setGlobalUserID(string userid)
        {
            GlobalUserID = userid;
        }
    }
}

