namespace FizzBuzzApp.Factories
{
    public class InvalidItemHandler : IFizzBuzzHandler
    {
        public string HandleValue(int inputVal)
        {
            return "Invalid Value";
        }
    }
}
