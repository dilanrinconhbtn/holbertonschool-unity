using System;
using System.Collections.Generic;


class List {
    public static int Sum(List<int> myList) {
        int sum = 0;
        HashSet<int> newList = new HashSet<int>();
        foreach (int number in myList)
        {
            newList.Add(number);
        }
        foreach (var item in newList)
        {
            sum = sum + item;
        }
        return sum;
    }
}