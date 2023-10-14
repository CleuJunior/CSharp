using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private readonly string _baseWord;
    public Anagram(string baseWord) => _baseWord = baseWord.ToLower();

    public string[] FindAnagrams(string[] potentialMatches) =>
        potentialMatches.Where(s => IsAnagram(s.ToLower())).ToArray();


    private bool IsAnagram(string candidate)
    {
        return candidate == _baseWord
            ? false
            : (string.Concat(candidate.OrderBy(c => c)) == string.Concat(_baseWord.OrderBy(c => c)));
    }
}