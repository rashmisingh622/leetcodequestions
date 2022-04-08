// See https://aka.ms/new-console-template for more information
using LeetCodeQuestions;

Console.WriteLine("Hello, World!");
var reverseVowels = new ReverseVowelsOfString();
//var result = reverseVowels.ReverseVowels("a.");
var addString = new AddStrings();
//var result = addString.AddStrings1("1", "9");
var searchTarget = new SearchTargetInArray();
//var result = searchTarget.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 0);
var countSegments = new CountSegments();
//var result = countSegments.CountSegments1("    foo    bar");
var getTarget = new GetTarget();
//var result = getTarget.Search(new int[] { 1, 3 }, 3);

int[,] matrix = {{11,12,13,14},
                          {21,22,23,24},
                          {31,32,33,34}};

//var result = array.Where(x => array[x] == array[x + 1]).First();
//Console.WriteLine(result);

//var result = FindNeedle.StrStr("mississippi", "issip");
//var result1 = new ValidPalindrome().RepeatedSubstringPattern("abab");
var result2 = HammingDistance.HammingDistance1(1, 4);
//Console.WriteLine(result);
Console.ReadLine();
