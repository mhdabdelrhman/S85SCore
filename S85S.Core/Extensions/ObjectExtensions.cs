using S85S.Core.Helpers;
using System;

namespace S85S.Core.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToJSON(this object o)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }

        public static int ToInt(this object o)
        {
            return DataFormat.GetInteger(o);
        }

        public static bool IsInt(this object o)
        {
            return DataFormat.IsInteger(o);
        }

        public static long ToLong(this object o)
        {
            return DataFormat.GetLong(o);
        }

        public static bool IsLong(this object o)
        {
            return DataFormat.IsLong(o);
        }

        public static double ToDouble(this object o)
        {
            return DataFormat.GetDouble(o);
        }

        public static bool IsDouble(this object o)
        {
            return DataFormat.IsDouble(o);
        }

        public static decimal ToDecimal(this object o)
        {
            return DataFormat.GetDecimal(o);
        }

        public static bool IsDecimal(this object o)
        {
            return DataFormat.IsDecimal(o);
        }

        public static string ToText(this object o)
        {
            return DataFormat.GetString(o);
        }

        public static float ToFloat(this object o)
        {
            return (float)DataFormat.GetDouble(o);
        }

        public static bool IsFloat(this object o)
        {
            return DataFormat.IsDouble(o);
        }

        public static bool ToBoolean(this object o)
        {
            return DataFormat.GetBoolean(o);
        }

        public static bool IsBoolean(this object o)
        {
            return DataFormat.IsBoolean(o);
        }

        public static DateTime ToDateTime(this object o)
        {
            return DataFormat.GetDateTime(o);
        }

        public static bool IsDateTime(this object o)
        {
            return DataFormat.IsValidDateTime(o);
        }

        public static DateTime? ToNullAbleDateTime(this object o)
        {
            return DataFormat.GetNullAbleDateTime(o);
        }
    }
}
