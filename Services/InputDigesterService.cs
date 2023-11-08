using SOLIDCalculator.Interfaces;
using SOLIDCalculator.Models;

namespace SOLIDCalculator.Services
{
    public class InputDigesterService : IInputDigester
    {
        public IDigestedInput DigestInput(string input)
        {
            List<float> numbers = new();
            List<char> operators = new();
            bool isNegative = false;

            // handle negative numbers
            if (input[0] == '-')
            {
                isNegative = true;
            }

            // Separate numbers and operations
            string currentNumber = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    currentNumber += c;
                    if (isNegative)
                    {
                        currentNumber = '-' + currentNumber;
                        isNegative = false;
                    }
                }
                else if (!isNegative)
                {
                    numbers.Add(float.Parse(currentNumber));
                    currentNumber = "";
                    operators.Add(c);
                }
            }
            numbers.Add(float.Parse(currentNumber));

            return new DigestedInput(numbers, operators);
        }
    }

}