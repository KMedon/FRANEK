namespace Zadanie1_Franek
{
    public class Rental
    {
        private int _clientAge;
        private int _rentalTime;
        private string _insurenceType;

        public string InsurenceType
        {
            get => _insurenceType;
            set => _insurenceType = value;
        }
        public int ClientAge
        {
            get => _clientAge;
            set => _clientAge = value;
        }
        public int RentalTime
        {
            get => _rentalTime;
            set => _rentalTime = value;
        }
        public Rental(string insurenceType = "", int clientAge = 0, int rentalTime = 0)
        {
            _insurenceType = insurenceType;
            _clientAge = clientAge;
            _rentalTime = rentalTime;

        }
    }
}
