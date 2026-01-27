// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var readLine = Console.ReadLine();
int[] coins = readLine.Split(' ').Select(s => int.Parse(s)).ToArray();
var amount = int.Parse(Console.ReadLine());

var solution322 = new Solution322();

var result = solution322.CoinChange(coins, amount);

Console.WriteLine(result);