namespace S85S.Core.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToFormatedMoney(this decimal d, string currencySymbol = null)
        {
            var str = string.Format(Config.MoneyFormat, d);
            if (!currencySymbol.IsEmpty())
                str = $"{currencySymbol} {str}";
            return str;
        }
    }
}
