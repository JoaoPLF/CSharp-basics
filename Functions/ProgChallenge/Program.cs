using System;
using System.Text;

string word = "";
var result = (false, 0);

(bool, int) PalindromeDetector(string pal) {
  string teststr;
  var sb = new StringBuilder();

  teststr = pal.ToLower();

  foreach (char c in teststr) {
    if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) {
      sb.Append(c);
    }
  }

  teststr = sb.ToString();

  int i = 0, j = teststr.Length - 1;

  while (i <= j) {
    if (teststr[i] != teststr[j]) {
      return (false, 0);
    }

    i++;
    j--;
  }

  return (true, pal.Length);
};

Console.WriteLine("Let's begin:");

while (word != "exit") {
  word = Console.ReadLine();

  if (word != "exit") {
    result = PalindromeDetector(word);
    Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
  }
}

