using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    internal static class DbValueHelper
    {
        public static object ToDbValue(this int? originalValue)
        {
            return originalValue.HasValue ? originalValue.Value : DBNull.Value;
        }
        public static object ToDbValue(this string? original)
        {
            return original != null ? original : DBNull.Value;
        }
        public static object ToDbValue(this short? original)
        {
            return original != null ? original : DBNull.Value;
        }
        public static object ToDbValue(this decimal? original)
        {
            return original != null ? original : DBNull.Value;
        }
    }
}
