using SOLIDCalculator.Interfaces;

namespace SOLIDCalculator.Services
{
    public class ArithmeticCalculator : ICalculator
    {
        public float Calculate(IDigestedInput digestedInput)
        {
            List<float> numbers = digestedInput.Numbers;
            List<char> operators = digestedInput.Operators;
            List<char> validOperators = new() { 'x', '/', '+', '-' };

            while (operators.Count > 0)
            {
                int index = -1;
                foreach (char operation in validOperators)
                {
                    index = operators.IndexOf(operation);
                    if (index != -1)
                    {
                        break;
                    }
                }

                float left = numbers[index];
                float right = numbers[index + 1];
                char currentOperator = operators[index];
                float result = currentOperator switch
                {
                    'x' => left * right,
                    '/' => left / right,
                    '+' => left + right,
                    '-' => left - right,
                    _ => 0,
                };
                numbers[index] = result;
                numbers.RemoveAt(index + 1);
                operators.RemoveAt(index);
            }
            float answer = numbers[0];

            return answer;
        }
    }
}