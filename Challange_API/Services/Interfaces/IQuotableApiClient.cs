using Challange_API.Models;

namespace Challange_API.Services.Interfaces
{
    public interface IQuotableApiClient
    {
        Task<Quote> GetRandomQuoteAsync();
        Task<QuotesResponse> GetQuotesByAuthorAsync(string author, int count);
    }
}
