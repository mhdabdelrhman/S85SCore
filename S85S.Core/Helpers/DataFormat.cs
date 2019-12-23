using System;

namespace S85S.Core.Helpers
{
    internal static class DataFormat
    {
        #region Core Formatting Metods
        public static bool IsValidDateTime(string date)
        {
            bool retValue = false;
            DateTime result = new DateTime();
            if (DateTime.TryParse(date, out result))
            {
                retValue = true;
            }

            return retValue;
        }

        public static bool IsValidDateTime(object date)
        {
            bool retValue = false;
            DateTime result = new DateTime();

            if (date != null)
            {
                if (DateTime.TryParse(date.ToString(), out result))
                {
                    retValue = true;
                }
            }

            return retValue;
        }

        public static DateTime GetDateTime(string date)
        {
            DateTime retValue = new DateTime();
            if (IsValidDateTime(date))
            {
                retValue = Convert.ToDateTime(date);
            }

            return retValue;
        }

        public static DateTime GetDateTime(object date)
        {
            DateTime retValue = new DateTime();
            if (IsValidDateTime(date))
            {
                retValue = Convert.ToDateTime(date);
            }

            return retValue;
        }

        public static DateTime? GetNullAbleDateTime(object date)
        {
            DateTime? retValue = null;
            if (IsValidDateTime(date))
            {
                retValue = Convert.ToDateTime(date);
            }

            return retValue;
        }

        public static bool IsDouble(object value)
        {
            bool retValue = false;

            if (value != null)
            {
                retValue = IsDouble(value.ToString());
            }

            return retValue;
        }

        public static bool IsDouble(string value)
        {
            bool retValue = false;
            double result = 0;
            if (value != null)
            {
                retValue = double.TryParse(value, out result);
            }

            return retValue;
        }

        public static bool IsDecimal(object value)
        {
            bool retValue = false;

            if (value != null)
            {
                retValue = IsDecimal(value.ToString());
            }

            return retValue;
        }

        public static bool IsDecimal(string value)
        {
            bool retValue = false;
            decimal result = 0;
            if (value != null)
            {
                retValue = decimal.TryParse(value, out result);
            }

            return retValue;
        }


        public static bool IsInteger(object value)
        {
            bool retValue = false;

            if (value != null)
            {
                retValue = IsInteger(value.ToString());
            }

            return retValue;
        }

        public static bool IsInteger(string value)
        {
            bool retValue = false;
            int result = 0;
            if (value != null)
            {
                retValue = int.TryParse(value, out result);
            }

            return retValue;
        }

        public static bool IsLong(object value)
        {
            bool retValue = false;

            if (value != null)
            {
                retValue = IsLong(value.ToString());
            }

            return retValue;
        }

        public static bool IsLong(string value)
        {
            bool retValue = false;
            long result = 0;
            if (value != null)
            {
                retValue = long.TryParse(value, out result);
            }

            return retValue;
        }

        public static bool IsBoolean(string value)
        {
            bool retValue = false;
            bool result = false;
            if (value != null)
            {
                retValue = bool.TryParse(value, out result);
            }

            return retValue;
        }


        public static bool IsBoolean(object value)
        {
            bool retValue = false;

            if (value != null)
            {
                retValue = IsBoolean(value.ToString());
            }

            return retValue;
        }

        public static string GetString(object value)
        {
            string retValue = string.Empty;
            if (value != null)
            {
                retValue = value.ToString();
            }

            return retValue;
        }


        public static int GetInteger(object value)
        {
            int retValue = 0;

            if (IsInteger(value))
            {
                retValue = Convert.ToInt32(value);
            }

            return retValue;
        }


        public static int GetInteger(string value)
        {
            int retValue = 0;

            if (IsInteger(value))
            {
                retValue = Convert.ToInt32(value);
            }

            return retValue;
        }


        public static long GetLong(object value)
        {
            long retValue = 0;

            if (IsLong(value))
            {
                retValue = Convert.ToInt64(value);
            }

            return retValue;
        }


        public static long GetLong(string value)
        {
            long retValue = 0;

            if (IsInteger(value))
            {
                retValue = Convert.ToInt64(value);
            }

            return retValue;
        }

        public static double GetDouble(object value)
        {
            double retValue = 0;

            if (IsDouble(value))
            {
                retValue = Convert.ToDouble(value);
            }

            return retValue;
        }


        public static double GetDouble(string value)
        {
            double retValue = 0;

            if (IsDouble(value))
            {
                retValue = Convert.ToDouble(value);
            }

            return retValue;
        }

        public static decimal GetDecimal(object value)
        {
            decimal retValue = 0;

            if (IsDecimal(value))
            {
                retValue = Convert.ToDecimal(value);
            }

            return retValue;
        }


        public static decimal GetDecimal(string value)
        {
            decimal retValue = 0;

            if (IsDecimal(value))
            {
                retValue = Convert.ToDecimal(value);
            }

            return retValue;
        }

        public static bool GetBoolean(object value)
        {
            bool retValue = false;

            if (IsBoolean(value))
            {
                retValue = Convert.ToBoolean(value);
            }

            return retValue;
        }


        public static bool GetBoolean(string value)
        {
            bool retValue = false;

            if (IsBoolean(value))
            {
                retValue = Convert.ToBoolean(value);
            }

            return retValue;
        }
        #endregion
    }
}
