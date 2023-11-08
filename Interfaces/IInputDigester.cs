namespace SOLIDCalculator.Interfaces
{
    public interface IInputDigester
    {
        IDigestedInput DigestInput(string input);
    }

    public interface IDigestedInput
    {
        List<float> Numbers { get; }
        List<char> Operators { get; }
    }
}