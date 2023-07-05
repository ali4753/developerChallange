using System.Text.Json.Serialization;

namespace Challange_API.Models
{


    public class QuotesResponse
    {
        public int Count { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int? LastItemIndex { get; set; }
        public List<Quote> Results { get; set; }
    }

    public class Quote
    {
        public string _id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public string AuthorSlug { get; set; }
        public int Length { get; set; }
        public string DateAdded { get; set; }
        public string DateModified { get; set; }
    }




}
