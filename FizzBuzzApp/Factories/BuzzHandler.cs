namespace FizzBuzzApp.Factories
{
    public class BuzzHandler : IFizzBuzzHandler
    {
        public string HandleValue(int inputVal)
        {
            return (inputVal % 5 == 0) ? "Buzz" : null;
        }
    }
}
