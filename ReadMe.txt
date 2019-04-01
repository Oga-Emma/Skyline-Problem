Skyline-Problem
Consider you are given a set of n rectangles in no particular order. They have varying widths and heights, but their bottom edges are lying in the same straight line. In other words they resemble buildings on a skyline. 
For each building, you are given the height of building as it is an element of integer array.For instance;
if A,given array, was [0,2,5,4,0,4,1], the building cluster would be the illustration below
    
4     *
3     * *   *
2     * *   *
1   * * *   *
0   * * *   * *
  0 1 2 3 4 5 6 

You'd like to paint the buildings by applying uninterrupted horizontal brushstrokes. Every horizontal stroke is one unit high and arbitrarlily wide.
The goal is to calculate the min number of horizontal brushstrokes needed. For instance 
                      Num of brushstrokes needed
4     *                 1
3     * *   *           2
2     * *   *           2
1   * * *   *           2
0   * * *   * *         2
  0 1 2 3 4 5 6 
the output for the aforementioned array would be = 9
