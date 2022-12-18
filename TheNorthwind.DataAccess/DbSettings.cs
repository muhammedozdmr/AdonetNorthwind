using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    public static class DbSettings
    {
        public static string ConnectionString
        {
            get
            {
                return "Server=.; Database=Northwnd; Integrated Security=true;";
            }
        }
    }
}
