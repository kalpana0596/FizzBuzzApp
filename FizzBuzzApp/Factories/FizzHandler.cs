namespace FizzBuzzApp.Factories
{
    public class FizzHandler : IFizzBuzzHandler
    {
        public string HandleValue(int inputVal)
        {
            return (inputVal % 3 == 0 ) ? "Fizz" : null;
        }
    }
}
