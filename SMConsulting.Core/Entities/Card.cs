namespace SMConsulting.Core.Entities
{
    public class Card
    {
        public int CardId    { get; set; }
        public string CardTitle { get; set; }
        public string CardDescription { get; set; }
        public string CardIcon { get; set; }
        public DateTime CardCreatedAt { get; set; } = DateTime.Now;
    }
}
