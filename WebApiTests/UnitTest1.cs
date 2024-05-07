using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace WebApiTests;

public class UnitTest1(WebApplicationFactory<Program> webApplicationFactory) : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task Test1()
    {
        // Arrange
        var client = webApplicationFactory.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<WeatherForecast[]>("/weatherforecast");

        // Assert
        Assert.Equal(5, response!.Length);
    }
}