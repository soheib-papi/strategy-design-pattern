namespace strategy_design_pattern.strategy;
public class GrayScaleFilter : IFilter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying Grayscale filter to " + fileName);
    }
}
