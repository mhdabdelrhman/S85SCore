using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace S85S.Core.Test
{
    using S85S.Core.Extensions;
    using System;

    [TestClass]
    public class ExtensionsTester
    {
        [TestMethod]
        public void TestIntExtensions()
        {
            var json = 10.ToJSON();
            //Console.WriteLine($"10 json is {json}");
            StringAssert.Equals(json, "10");
            json = (new { Name = "Mohammed", Age = 35, Gender = "Male" }).ToJSON();
            //System.Diagnostics.Trace.WriteLine($"object json is {json}");
            StringAssert.StartsWith(json, "{");
            StringAssert.EndsWith(json, "}");
        }
    }
}
