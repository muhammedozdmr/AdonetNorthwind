using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    internal static class DataReaderHelper
    {
        // DataReaderHelper sınıfı, dataReader nesneleri üzerindeki NULL veri döndürebilecek
        // alanların değerlerini ternary kullanarak cast etme işi yapan metotları barındıracak

        // Bu sebepten dolayı DataReaderHelper'ın instance alınabilir bir sınıf olmasına gerek yok
        // Çünkü metot parametresi olarak hem dataReader hem de fieldName bilgilerini anlık olarak
        // dışarıdan alabiliyorum

        // Diğer bir ifadeyle; DataReaderHelper sınıfının bir DURUM (object state) tutmasına gerek yok
        // Bu sebepledir ki; bu sınıf static yazılabilir

        // static => Yazılımın yaşam süresi boyunca yalnızca bir instance'ının oluşacağı tipler

        // Extension Method
        public static int? GetInt32Nullable(this SqlDataReader dataReader, string fieldName)
        {
            return dataReader[fieldName] == DBNull.Value
                ? default(int?)
                : (int)dataReader[fieldName];
        }

        public static decimal? GetDecimalNullable(this SqlDataReader dataReader, string fieldName)
        {
            return dataReader.IsDBNull(fieldName)
                ? default(decimal?)
                //: (decimal)dataReader[fieldName];
                : dataReader.GetDecimal(fieldName);
        }

        public static short? GetInt16Nullable(this SqlDataReader dataReader, string fieldName)
        {
            return dataReader.IsDBNull(fieldName)
                ? null
                : dataReader.GetInt16(fieldName);
        }

        public static string? GetStringNullable(this SqlDataReader dataReader, string fieldName)
        {
            return dataReader.IsDBNull(fieldName)
                ? null
                : dataReader.GetString(fieldName);
        }
        //public static  DateTime? GetDateTimeNullable(this SqlDataReader dataReader,DateTime fieldName)
        //{

        //    return dataReader.IsDBNull(fieldName) ? null : dataReader.GetDateTime(fieldName);
        //}
    }
}
