using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind
{
    //Entity sınıflarında tek bir satırı aldığı için isimlerndirme tek olmak zorunda Category gibi
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
