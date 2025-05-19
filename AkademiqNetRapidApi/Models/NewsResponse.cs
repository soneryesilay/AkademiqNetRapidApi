namespace AkademiqNetRapidApi.Models
{
    public class NewsResponse
    {
        public List<NewsItem> data { get; set; }
    }

    public class NewsItem
    {
        public string title { get; set; }
    }
}
