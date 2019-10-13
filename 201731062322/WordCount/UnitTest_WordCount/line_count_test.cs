using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace UnitTest_WordCount
{
    [TestClass]
    public class line_count_test
    {
        [TestMethod]
        public void TestMethod1()
        {
            file_path.input_path = @"E:\GITwrod\WordCount\201731062322\WordCount\UnitTest_WordCount\testfile.txt";
            int x = 0;
            Assert.AreEqual(x, line_count.lines());
            // Assert.Fail();
        }
    }
}
