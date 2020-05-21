using System;
using System.Collections.Generic;

class List {
    public static List<int> DifferentElements (List<int> list1, List<int> list2) {
        List<int> myList = new List<int> ();
        foreach (int number1 in list1) {
            if (!(list1.Contains (number1) && list2.Contains (number1))) {
                myList.Add (number1);
            }
        }
        foreach (int number2 in list2) {
            if (!(list1.Contains (number2) && list2.Contains (number2))) {
                myList.Add (number2);
            }
        }
        for(int i = 0; i < myList.Count; i++)
        {
            
        }
        return myList;
    }
}