using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDD.UI;

namespace TDDTest.Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var mock = new Mock<IDB>();
            mock.Setup(x => x.getDBValue()).Returns(100);
            var viewModel = new Form1ViewModel(mock.Object);
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            viewModel.CalculationAction();
            Assert.AreEqual("107",viewModel.ResultLabelText);

            viewModel.ATextBoxText = "-1";
            viewModel.BTextBoxText = "3";
            AssertEx.Throws<InputException>(() => viewModel.CalculationAction());

        }

        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void 例外()
        {
            Assert.AreEqual(1, Calculation.Sum(-1, 2));
        }


    }

    //internal class DBMock : IDB
    //{
    //    public int getDBValue()
    //    {
    //        return 100;
    //    }
    //}
}
