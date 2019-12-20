namespace S85S.Core.Extensions
{
    public static class DoubleExtensions
    {
        public static string ToFormatedMoney(this double d, string currencySymbol = null)
        {
            return ((decimal)d).ToFormatedMoney(currencySymbol);
        }
    }
}
