namespace FizzBuzzApp.Factories
{
    public class FizzBuzzHandler: IFizzBuzzHandler
    {
        public string HandleValue(int inputVal)
        {
            return (inputVal % 3 == 0 && inputVal % 5 == 0) ? "FizzBuzz" : null;
        }
    }
}
