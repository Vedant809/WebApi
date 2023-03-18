using System;

namespace CricketAPI.Entity
{
    public class Cricket
    {
        public int Id { get; set; }
        public string? PlayerName { get; set; }
        public long? Runs { get; set; }   
        public string? Role { get; set; }
        public DateTime Debut { get; set; }


    }
}
