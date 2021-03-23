using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] T) {
        int size = T.Length;
        int candiesToGive = size / 2;

        List<int> candy = new List<int>();

        Array.Sort(T);

        for (int i = 0; i < size; i++)
        {
            int j;
            for (j = 0; j < i; j++)
                if (T[i] == T[j])
                    break;

            if (i == j)
                candy.Add(T[i]);
        }

        if(candy.Count > candiesToGive)
        {
            return candiesToGive;
        }
        else
        {
            return candy.Count;
        }
    }
}
