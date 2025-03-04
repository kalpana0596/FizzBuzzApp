namespace FizzBuzzApp.Factories
{
    public class FizzBuzzFactory
    {
        public static IFizzBuzzHandler CreateHandler(object inputVal)
        {
            if (inputVal == null || string.IsNullOrEmpty(inputVal.ToString()))
                return new InvalidItemHandler();

            if (int.TryParse(inputVal.ToString(), out int inputValue))
            {
                if (inputValue % 3 != 0 && inputValue % 5 != 0)
                    return new NotFizzBuzzHandler();
                if (inputValue % 3 == 0 && inputValue % 5 == 0)
                    return new FizzBuzzHandler();
                if (inputValue % 3 == 0)
                    return new FizzHandler();
                if (inputValue % 5 == 0)
                    return new BuzzHandler();

                return new InvalidItemHandler();
            }     
              
            


            return new InvalidItemHandler();

        }
    }
}
