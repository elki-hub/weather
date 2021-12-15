using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Collections.Generic;
using WeatherApplication.DataProvider;

namespace MoqTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var provider = new Mock<IRestApi>(MockBehavior.Strict);
            var repo = new Repository(provider.Object);

            provider.Setup(m => m.GetLocations("ameri")).Returns(new List<SearchModel>
            {
                    new SearchModel {Title = "London", Woeid = 1234},
                    new SearchModel {Title = "Vienna", Woeid = 6464164},
                    new SearchModel {Title = "Amsterdam", Woeid = 5873},
                    new SearchModel {Title = "Roma", Woeid = 8767},
                    new SearchModel {Title = "Paris", Woeid = 76383},

            });
            Assert.AreEqual(4, repo.countList("ameri"));
        }
    }
}
