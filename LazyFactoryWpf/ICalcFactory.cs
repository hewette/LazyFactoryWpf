namespace LazyFactoryWpf
{
    public interface ICalcFactory
    {
        ICalc getCalculatorFunction(CalcFactory.CalcTypes calcType);
    }
}
