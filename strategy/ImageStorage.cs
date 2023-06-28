namespace strategy_design_pattern.strategy;
public class ImageStorage
{
    private ICompressor _compressor;
    private IFilter _filter;
    public ImageStorage(ICompressor compressor, IFilter filter)
    {
        _compressor = compressor;
        _filter = filter;
    }

    public void Store(string fileName)
    {
        _compressor.Compress(fileName);
        _filter.Apply(fileName);
    }
}
