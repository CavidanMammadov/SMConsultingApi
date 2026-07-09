namespace SMConsulting.BL.DTOs.SocialMedia
{
    public class SocialMediaGetAllDto
    {
        public string SocialMediaId { get; set; }
        public string SocialMediaFacebookUrl { get; set; }
        public string SocialMediaInstagramUrl { get; set; }
        public string SocialMediaLinekdinUrl { get; set; }
        public string SocialMediaYoutubeUrl { get; set; }
        public DateTime SocialMediaCreatedAt { get; set; }
    }
}
