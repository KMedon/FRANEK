namespace Zadanie1_Franek
{
    public class CostumesRental : Rental
    {
        private string _genderClient;

        public string GenderClient
        {
            get => _genderClient;
            set => _genderClient = value;
        }
        public CostumesRental(string genderClient = "",string insurenceType = "", int rentalTime = 0, int clientAge = 0) : base(insurenceType, rentalTime, clientAge)
        {
            _genderClient = genderClient;
        }
    }
}
