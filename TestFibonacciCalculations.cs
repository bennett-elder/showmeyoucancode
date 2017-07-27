// https://en.wikipedia.org/wiki/Fibonacci_number

// F(n) = F(n-1) + F(n-2)
// F(0) = 0
// F(1) = 1

using System;

public class TestFibonacciCalculations {
    public static void Main() {
        RunTest(0, 0);
        RunTest(1, 1);
        RunTest(9, 34);
        RunTest(30, 832040);
    }

    // ask candidate to create Fibo()

    // ask candidate to create test harness for added challenge
    private static void RunTest(int tested, int expectedResult) {
        bool didPass = Fibo(tested) == expectedResult;

        Console.WriteLine("Testing Fib(" + tested + ") - " + (didPass ? "Pass" : "Fail"));
    }    
}
