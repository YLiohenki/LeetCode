// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var MedianFinder = new MedianFinder();
//
//MedianFinder.AddNum(1);
//MedianFinder.AddNum(2);
//
//Console.WriteLine(MedianFinder.FindMedian());
//MedianFinder.AddNum(3);
//Console.WriteLine(MedianFinder.FindMedian());

var DecodeWays = new DecodeWays();

var str = Console.ReadLine();

var number = DecodeWays.NumDecodings(str);

Console.WriteLine(number);

Console.ReadKey();