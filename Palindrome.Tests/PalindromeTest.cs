using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Palindrome.Models;
using System;
namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void IsPalindrome_shouldReturnTrue_Boolean()
    {
      bool expected = true;
      PalindromeClass pmd = new PalindromeClass("aabcbaa");
      bool actual = pmd.IsPalindrome();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void IsPalindrome_shouldReturnFalse_Boolean()
    {
      string expected = false;
      PalindromeClass pmd = new PalindromeClass("abcdef");
      bool actual = pmd.IsPalindrome();
      Assert.AreEqual(expected, actual);
    }
  }
}
