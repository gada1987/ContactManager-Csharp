using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class GlobalData
    {
        //CLASS TO RETURN AND SET THE USERS ID
        public static int GlobalUserId { get; private set; } 
        public static void setGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
