namespace SMConsulting.BL.DTOs.Training
{
    public class TrainingGetAllDto
    {
        public int TrainingId { get; set; }
        public string TrainingTitle { get; set; }
        public string TrainingDescription { get; set; }
        public DateTime TrainingCreatedAt { get; set; }
    }
}
