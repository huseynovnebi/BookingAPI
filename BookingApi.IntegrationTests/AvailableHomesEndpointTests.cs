using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookingApi.IntegrationTests
{
    public class AvailableHomesEndpointTests
    {
        private readonly WebApplicationFactory<Program> _factory;

        public AvailableHomesEndpointTests()
        {
            _factory = new WebApplicationFactory<Program>();
        }

        [Fact]
        public async Task Get_AvailableHomes_ReturnsOk()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("api/available-homes?startDate=2030-01-01&endDate=2030-01-03");

            response.StatusCode.Should().Be(HttpStatusCode.OK,because:"The status code shoul be OK");
            var content = await response.Content.ReadFromJsonAsync<AvailableHomesResponse>();

            content!.Homes.Should().Contain(h => h.HomeId == 1001,because:"In these example reponce have to contain home1001");
        }
    }
}
