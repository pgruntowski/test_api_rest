namespace WebApp
{
    public class Player
    {
        public int Id { get; set; }
        public required string Nickname { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
