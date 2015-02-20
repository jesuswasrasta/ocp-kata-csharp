#region Usings
using System.Collections.Generic;
using System.Linq;
using System.Text;


#endregion


namespace Ocp.FizzBuzz
{
	public class FizzBuzzGame
	{
		#region Fields
		private readonly IList<IRegola> _regole;
		#endregion


		#region Constructors
		public FizzBuzzGame()
		{
			_regole = new List<IRegola>();
		}
		#endregion


		#region name
		public void AddRule(IRegola regola)
		{
			_regole.Add(regola);
		}

		public string Say(int number)
		{
			var result = new StringBuilder(number.ToString());
			var regoleApplicabili = _regole.Where(r => r.Applicabile(number)).OrderBy((r => r.Divisore)).ToList();
		
			foreach (var regola in regoleApplicabili)
			{
				result.Replace(number.ToString(), string.Empty);//Tricky :]
				result.Append(regola.GetRappresentazione(number));
			}

			return result.ToString();
		}
		#endregion
	}
}