// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World!");

//var MedianFinder = new MedianFinder();
//
//MedianFinder.AddNum(1);
//MedianFinder.AddNum(2);
//
//Console.WriteLine(MedianFinder.FindMedian());
//MedianFinder.AddNum(3);
//Console.WriteLine(MedianFinder.FindMedian());

//var c = new ProductofArrayExceptSelf();
//
//var result = c.ProductExceptSelf(Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray());
//
//Console.WriteLine(string.Join(',', result));

//var s = new Solution6();
//Console.WriteLine(s.Convert("PAYPALISHIRING", 4));
//
//Console.WriteLine(s.Convert("A", 1));
var s = new Solution7();
Console.WriteLine(s.Reverse(123));

Console.WriteLine(s.Reverse(- 2147483648));

Console.ReadKey();