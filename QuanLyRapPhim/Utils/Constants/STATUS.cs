using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.Utils.Constants
{
    public class STATUS
    {
        public static int ACTIVE = 1;
        public static int INACTIVE = 0;

        public static Hashtable Status = new Hashtable()
        {
            {ACTIVE, "Đang hoạt động" },
            {INACTIVE, "Không hoạt động" }
        };
    }
}