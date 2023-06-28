namespace strategy_design_pattern.strategy;
public class BlackAndWhiteFilter : IFilter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying B/W filter to " + fileName);
    }
}
