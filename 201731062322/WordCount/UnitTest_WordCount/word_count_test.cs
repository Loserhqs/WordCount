using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace UnitTest_WordCount
{
    /// <summary>
    /// word_count_test 的摘要说明
    /// </summary>
    [TestClass]
    public class word_count_test
    {
        public word_count_test()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_word_sum()
        {
            //
            // TODO:  在此处添加测试逻辑
            //
            Dictionary<string, int> frequen = new Dictionary<string, int>();
            file_path.output_path=@"E:\GITwrod\WordCount\201731062322\WordCount\UnitTest_WordCount\testoutfile.txt";
            string a = "word";
            frequen.Add(a, 1);
            //frequen.Add("word",1);
            Assert.AreEqual(1, word_count.word_sum(frequen));
            //   Assert.Fail();
        }
        [TestMethod]
        public void Test_word_frequency()
        {
            //
            // TODO:  在此处添加测试逻辑
            //
            file_path.input_path = @"E:\GITwrod\WordCount\201731062322\WordCount\UnitTest_WordCount\testfile.txt";
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            Dictionary<string, int> frequencies1 = new Dictionary<string, int>();
            frequencies.Add("word1", 1);
            //  Assert.AreEqual(wordcount.Countword(ref frequencies1 , 0),frequencies);
            //  Assert.Fail();
        }
    }
}
