using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayTestMode
{
    
    [Test]
    public void TestIsOdd()
    {
        Assert.IsTrue(MyLib.IsOdd(2));
        Assert.IsTrue(MyLib.IsOdd(0));
        Assert.IsTrue(MyLib.IsOdd(-2));
        Assert.IsTrue(MyLib.IsOdd(int.MinValue));
        

        Assert.IsFalse(MyLib.IsOdd(3));
        Assert.IsFalse(MyLib.IsOdd(1));
        Assert.IsFalse(MyLib.IsOdd(-9));
        Assert.IsFalse(MyLib.IsOdd(int.MaxValue));

    }
    

    
}
