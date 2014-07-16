namespace Ocp.FizzBuzz
{
    public class RegolaMultiploDi5 : IRegola
    {
        private const int _divisore = 5;
        public int Divisore
        {
            get { return _divisore; }
        }

        public string GetRappresentazione(int number)
        {
            return number % Divisore == 0 ? "Buzz" : string.Empty;
        }

        public bool Applicabile(int number)
        {
            return number % Divisore == 0;
        }
    }
}