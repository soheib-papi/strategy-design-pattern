namespace strategy_design_pattern.strategy;
public class JpegCompressor : ICompressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine("JPEG Compressing " + fileName);
    }
}
