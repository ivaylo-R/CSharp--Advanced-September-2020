namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

        public string Model { get; set; }
        public string Make { get; set; }
        public int Year 
        {
            get 
            {
                return year;
            } 
            set 
            {
                this.year = value;
            }
        }

    }
}
