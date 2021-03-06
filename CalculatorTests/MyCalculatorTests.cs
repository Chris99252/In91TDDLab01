﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void AddTest_first_1_second_2_should_be_3()
        {
            //// Arrange 初始化
            var target = new MyCalculator(); //// 測試目標叫 target
            var first = 1; //// 參數名稱跟命名一樣 first
            var second = 2; //// 參數名稱跟命名一樣 second
            var expected = 3; //// expected 你期望的

            //// Act 驗證什麼行為
            var actual = target.Add(first, second); //// actual 實際得到的

            //// Assert 符合預期
            Assert.AreEqual(expected, actual); //// 測試：期望的跟你實際得到的一樣
        }
    }
}