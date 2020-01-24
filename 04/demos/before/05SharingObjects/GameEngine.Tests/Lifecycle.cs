using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameEngine.Tests
{
    [TestClass]
    public class Lifecycle
    {
        [TestInitialize]
        public void LifecycleInit()
        {
            Console.WriteLine("    TestInitialize Lifecycle");
        }

        [TestCleanup]
        public void LifecycleClean()
        {
            Console.WriteLine("    TestCleanup Lifecycle");
        }

        [ClassInitialize]
        public static void LifecycleClassInit(TestContext context)
        {
            Console.WriteLine("  ClassInitialize Lifecycle");
        }

        [ClassCleanup]
        public static void LifecycleClassClean()
        {
            Console.WriteLine("  ClassCleanup Lifecycle");
        }


        [TestMethod]
        public void TestA()
        {
            Console.WriteLine("      Test A starting");
        }


        [TestMethod]
        public void TestB()
        {
            Console.WriteLine("      Test B starting");
        }
    }
}
