using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLib : MonoBehaviour
{
    public static bool IsOdd(int number)
    {
        if (number % 2 == 0)
            return true;
        return false;

    }
}
