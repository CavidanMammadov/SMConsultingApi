namespace SMConsulting.BL.DTOs.Services
{
    public class ServiceGetAllDto
    {
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceFooter { get; set; }
        public string ServiceFooterDescription { get; set; }
        public DateTime ServiceCreatedAt { get; set; } = DateTime.Now;
    }
}
