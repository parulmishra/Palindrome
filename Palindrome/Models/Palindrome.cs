using System;
using System.Collections.Generic;

namespace Palindrome.Models
{
  public class PalindromeClass
  {
    private string _input;
    public PalindromeClass(string input)
    {
      _input = input;
    }
    public bool IsPalindrome()
    {
      for(int i = 0 , j = _input.Length-1 ; i <j;)
      {
        if(_input[i] == _input[j])
        {
          i++;
          j--;
        }
        else
        return false;
      }
      return true;
    }
  }
}
