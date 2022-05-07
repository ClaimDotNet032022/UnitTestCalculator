namespace CalculatorProject
{
    public interface IParser
    {
        BinaryOperation Parse(string exprString);
    }
}