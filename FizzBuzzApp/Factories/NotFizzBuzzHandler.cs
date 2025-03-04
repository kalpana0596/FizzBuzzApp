namespace FizzBuzzApp.Factories
{
    public class NotFizzBuzzHandler : IFizzBuzzHandler
    {
        public string HandleValue(int inputVal)
        {
            return (inputVal % 3 != 0 && inputVal % 5 != 0) ? "Divided " + inputVal + " By 3. Divided " + inputVal + " By 5" : null;
        }
    }
}
