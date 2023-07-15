// See https://aka.ms/new-console-template for more information
Console.WriteLine("Application started...");


Solution solution = new Solution();

int[] exampleArray = new int[] { 0, 4, 3, 0 };

var target = 0;

var result = solution.TwoSum(exampleArray, target);

Console.WriteLine("[{0}]", string.Join(", ", result));