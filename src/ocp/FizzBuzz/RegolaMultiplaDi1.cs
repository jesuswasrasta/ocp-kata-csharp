namespace Ocp.FizzBuzz
{
	public class RegolaMultiplaDi1 : IRegola
	{
		private const int _divisore = 1;

		public int Divisore
		{
			get { return _divisore; }
		}

		public string GetRappresentazione(int number)
		{
			return Applicabile(number) ? number.ToString() : string.Empty;
		}

		public bool Applicabile(int number)
		{
			return number%Divisore == 0;
		}
	}
}