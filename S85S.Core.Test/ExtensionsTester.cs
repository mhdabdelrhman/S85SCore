using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace S85S.Core.Test
{
    using S85S.Core.Extensions;
    using System;

    [TestClass]
    public class ExtensionsTester
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        [TestMethod]
        public void TestObjectExtensions()
        {
         
            Person p = new Person { Name = "Lana", Age = 25 };
            string json = p.ToJSON();
            Person fromJson = json.FromJSON<Person>();
            Assert.IsNotNull(fromJson);
            Assert.IsTrue(fromJson.Name == p.Name);
            Assert.IsTrue(fromJson.Age == p.Age);

        }
        [TestMethod]
        public void TestIntExtensions()
        {
            var json = 10.ToJSON();
            StringAssert.Equals(json, "10");
        }
        [TestMethod]
        public void TestStringExtensions()
        {
            var email = "test@test.com";
            Assert.IsTrue(email.IsEmail());

            var email2 = "test@@test.com";
            Assert.IsFalse(email2.IsEmail());
        }
    }
}
