using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocp.FizzBuzz
{
    public class FizzBuzzGame
    {
        private readonly IEnumerable<IRegola> _regole;

        public FizzBuzzGame(IEnumerable<IRegola> regole)
        {
            _regole = regole;
        }

        public string Say(int number)
        {
           var result = new StringBuilder();
            
            foreach (var rappresentazione in _regole.Select(r => r.GetRappresentazione(number)))
            {
                result.Append(rappresentazione);
            }
            
            return result.ToString();
        }
    }
}