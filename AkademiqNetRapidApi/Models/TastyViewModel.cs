namespace AkademiqNetRapidApi.Models
{

    public class RootTastyApi
    {
        public List<TastyApiViewModel> Results { get; set; }
    }

    public class TastyApiViewModel
    {
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string original_video_url { get; set; }
    }
}