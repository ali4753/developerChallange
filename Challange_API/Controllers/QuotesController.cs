using Challange_API.Models;
using Challange_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Challange_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private readonly IQuotableApiClient _quotableApiClient;

        public QuotesController(IQuotableApiClient quotableApiClient)
        {
            _quotableApiClient = quotableApiClient;
        }

        [HttpGet("random")]
        public async Task<ActionResult<Quote>> GetRandomQuote()
        {
            var quote = await _quotableApiClient.GetRandomQuoteAsync();
            return Ok(quote);
        }

        [HttpGet("author/{author}")]
        public async Task<ActionResult<QuotesResponse>> GetQuotesByAuthor(string author)
        {
            const int quoteCount = 30;
            var quotes = await _quotableApiClient.GetQuotesByAuthorAsync(author, quoteCount);

            var shortQuotes = quotes.Results.Where(q => q.Content.Split(' ').Length < 10);
            var mediumQuotes = quotes.Results.Where(q => q.Content.Split(' ').Length >= 10 && q.Content.Split(' ').Length <= 20);
            var longQuotes = quotes.Results.Where(q => q.Content.Split(' ').Length > 20);

            var categorizedQuotes = new
            {
                ShortQuotes = shortQuotes,
                MediumQuotes = mediumQuotes,
                LongQuotes = longQuotes
            };

            return Ok(categorizedQuotes);
        }
    }

}
