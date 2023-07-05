using Challange_API.Models;
using Challange_API.Services.Interfaces;
using System.Net;

namespace Challange_API.Services
{
    public class QuotableApiClient : IQuotableApiClient
    {
        private readonly HttpClient _httpClient;

        public QuotableApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Quote> GetRandomQuoteAsync()
        {
            var response = await _httpClient.GetAsync("random");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Quote>();
        }

        public async Task<QuotesResponse> GetQuotesByAuthorAsync(string author, int count)
        {
            var response = await _httpClient.GetAsync($"quotes?author={author}&limit={count}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<QuotesResponse>();
        }
    }

}
