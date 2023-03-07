namespace Zadanie1_Franek
{
    public class VehiclesRental : Rental
    {
        private string _vehicleType;
        private string _driverLicense;

        public string VehicleType
        {
            get => _vehicleType;
            set => _vehicleType = value;
        }
        public string DriverLicense
        {
            get => _driverLicense;
            set => _driverLicense = value;
        }
        public VehiclesRental(string vehicleType = "", string driverLicense = "", string insurenceType = "", int clientAge = 0, int rentalTime = 0) : base(insurenceType, clientAge, rentalTime)
        {
            _vehicleType = vehicleType;
            _driverLicense = driverLicense;
            
        }
    }
}
