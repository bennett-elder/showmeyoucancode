using System;
using System.Collections.Generic;

public class TestPalindromePermutations {
    
    public static void Main()     {
        RunTest("civil", false);
        RunTest("civic", true);
        RunTest("civic ", true);
        RunTest("ciilv", false);
        RunTest("cciiv", true);
        RunTest("never odd or even", true);
        RunTest("odd never or even", true);
        RunTest("odd never or even\t", true);
    }
    
    
    private static void RunTest(string testedString, bool expectedResult) {
        bool didPass = CanCharactersBeMadeIntoAPalindrome(testedString) == expectedResult;
        
        Console.WriteLine("Testing '" + testedString + "' - " + (didPass ? "Pass" : "Fail"));
    }
    
    private static bool CanCharactersBeMadeIntoAPalindrome(string testedString) {
        
        // implement this function
        
        return false;
        
    }
}
