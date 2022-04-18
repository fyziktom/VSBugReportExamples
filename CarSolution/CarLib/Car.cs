namespace CarLib
{
    public class Seat
    {
        public string Color { get; set; } = string.Empty;
    }
    public class Car
    {
        public string Owner { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }
}