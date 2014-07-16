namespace Ocp.FizzBuzz
{
    public class RegolaMultiplaDi7 : IRegola
    {
        private const int _divisore = 7;
        public int Divisore
        {
            get { return _divisore; }
        }

        public string GetRappresentazione(int number)
        {
            return number % Divisore == 0 ? "Bang" : string.Empty;
        }

        public bool Applicabile(int number)
        {
            return number % Divisore == 0;
        }
    }
}