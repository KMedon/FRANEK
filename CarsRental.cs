namespace Zadanie1_Franek
{
    public class CarsRental : VehiclesRental
    {
        private string _brand;
        private string _color;

        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public string Color
        {
            get => _color;
            set => _color = value;
        }
        public CarsRental(string brand = "", string color = "", string vehicleType = "", string driverLicense = "", string insurenceType = "", int clientAge = 0, int rentalTime = 0) : base(vehicleType, driverLicense, insurenceType, clientAge, rentalTime)
        {
            _brand = brand;
            _color = color;
        }
    }
}
