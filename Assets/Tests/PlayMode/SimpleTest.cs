using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SimpleTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void SimpleTestSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(2 + 2, 4);
    }
}
