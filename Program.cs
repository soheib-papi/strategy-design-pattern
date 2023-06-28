
using strategy_design_pattern.strategy;

var imageStorage = new ImageStorage(new PngCompressor(), new GrayScaleFilter());
imageStorage.Store("C:\\tree.jpeg");

Console.ReadLine();