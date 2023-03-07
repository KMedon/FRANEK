namespace Zadanie1_Franek
{
    public class SkiingRental : WinterSportsRental
    {
        private float _shoeNumber;
        private string _typeOfSkis;

        public float ShoeNumber
        {
            get => _shoeNumber;
            set => _shoeNumber = value;
        }
        public string TypeOfSkis
        {
            get => _typeOfSkis;
            set => _typeOfSkis = value;
        }   
        public SkiingRental(float shoeNumber = 0, string typeOfSkis = "", int height = 0, float weight = 0, string insurenceType = "", int clientAge = 0, int rentalTime = 0) : base(height, weight, insurenceType, clientAge, rentalTime)
        {
            _shoeNumber = shoeNumber;
            _typeOfSkis = typeOfSkis;
        }
    }   

}
