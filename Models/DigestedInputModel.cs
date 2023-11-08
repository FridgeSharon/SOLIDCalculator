using SOLIDCalculator.Interfaces;

namespace SOLIDCalculator.Models
{
    public class DigestedInput : IDigestedInput
    {
        public List<float> Numbers { get; }
        public List<char> Operators { get; }

        public DigestedInput(List<float> numbers, List<char> operators)
        {
            Numbers = numbers;
            Operators = operators;
        }
    }
}
