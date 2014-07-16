namespace Ocp.FizzBuzz
{
    public interface IRegola
    {
        int Divisore { get; }
        string GetRappresentazione(int number);
        bool Applicabile(int number);
    }
}