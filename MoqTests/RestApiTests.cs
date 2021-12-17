using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using RestSharp;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.DataProvider;

namespace MoqTests
{
    [TestClass]
    public class RestApiTests
    {
        private readonly Mock<IRestClient> _mockRestClient;
        public RestApiTests()
        {
            _mockRestClient = new Mock<IRestClient>();
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void GetImageUrl_BadString_InvalidFileName(string abbr)
        {
            //arrange
            var baseUrl = "http://test.com";
            var restApi = new RestApi(baseUrl, new RestClient());

            //act
            var result = restApi.GetImageUrl(abbr);

            //assert
            result.ShouldBe($"{baseUrl}/static/img/weather/png/.png");
            var isUrlValid = Uri.IsWellFormedUriString(result, UriKind.Absolute);
            isUrlValid.ShouldBeTrue();
            new Uri(result).IsFile.ShouldBeFalse();
        }


        [TestMethod]
        [DataRow("aa")]
        [DataRow("bb")]
        public void GetImageUrl_CorrectString_ValidFileName(string abbr)
        {
            //arrange
            var baseUrl = "http://test.com";
            var restApi = new RestApi(baseUrl, new RestClient());

            //act
            var result = restApi.GetImageUrl(abbr);

            //assert
            result.ShouldBe($"{baseUrl}/static/img/weather/png/{abbr}.png");
            var isUrlValid = Uri.IsWellFormedUriString(result, UriKind.Absolute);
            isUrlValid.ShouldBeTrue();
            new Uri(result).IsFile.ShouldBeTrue();
        }


        [TestMethod]
        public void GetByWoeid_WoeidNotFound_ReturnsNull()
        {
            //arrange
            //_mockRestClient.Setup(x => x.Get(It.IsAny<RestRequest>()));
            //var request = new RestRequest("api/location/123");
            var response = new Mock<IRestResponse>();
            response.Setup(x => x.StatusCode).Returns(HttpStatusCode.NotFound);
            response.Setup(x => x.Content).Returns("{details:\"Not Found.\"}");
            _mockRestClient
                .Setup(x => x.Execute(It.IsAny<IRestRequest>()))
                .Returns(response.Object);

            var restClient = _mockRestClient.Object;
            var baseUrl = "http://test.com";
            var restApi = new RestApi(baseUrl, restClient);

            //act
            var result = restApi.GetByWoeid(123);

            //assert
            result.ShouldBe(null);
        }

    }
}
