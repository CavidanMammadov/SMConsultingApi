namespace SMConsulting.BL.DTOs.Vision
{
    public class VisionGetAllDto
    {
        public int VisionId { get; set; }
        public string VisionSubDescription { get; set; }
        public string VisionDescription { get; set; }
        public DateTime VisionCreatedAt { get; set; }
    }
}
