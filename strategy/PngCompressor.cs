namespace strategy_design_pattern.strategy;
public class PngCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine("PNG Compressing " + fileName);
    }
}
