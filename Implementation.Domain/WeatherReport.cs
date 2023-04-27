namespace Implementation.Domain
{
    public class WeatherReport
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int WindStrength { get; set; }
        public string? WindDirection { get; set; }
    }
}