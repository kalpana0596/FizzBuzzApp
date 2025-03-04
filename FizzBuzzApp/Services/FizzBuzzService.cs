using FizzBuzzApp.Factories;

namespace FizzBuzzApp.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> CheckFizzBuzz(object[] values)
        {
            List<string> results = new List<string>();

            foreach (var value in values)
            {
                var handler = FizzBuzzFactory.CreateHandler(value);
                int.TryParse(value.ToString(), out int val);
                var result = handler.HandleValue(val);

                if (result != null)
                {
                    results.Add(result);

                }
            }

            return results;
        }
    }
}