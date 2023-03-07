namespace Zadanie1_Franek
{
    public class WinterSportsRental : Rental
    {
        private int _height;
        private float _weight;

        public int Height
        {
            get => _height;
            set => _height = value;
        }
        public float Weight
        {
            get => _weight;
            set => _weight = value;
        }
        public WinterSportsRental(int height = 0, float weight = 0, string insurenceType = "", int clientAge = 0, int rentalTime = 0) : base(insurenceType, clientAge, rentalTime)
        {
            _height = height;
            _weight = weight;
        }
    }
}
