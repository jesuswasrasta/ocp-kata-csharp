namespace Ocp.FizzBuzz
{
    public class RegolaMultiploDi3 : IRegola
    {
        private const int _divisore = 3;
        public int Divisore {
            get { return _divisore; }
        }

        public string GetRappresentazione(int number)
        {
            return number % Divisore == 0 ? "Fizz" : string.Empty;
        }

        public bool Applicabile(int number)
        {
            return number % Divisore == 0;
        }
    }
}