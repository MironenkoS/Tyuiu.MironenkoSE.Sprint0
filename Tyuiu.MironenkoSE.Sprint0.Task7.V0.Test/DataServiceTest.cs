using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MironenkoSE.Sprint0.Task7.V0.Lib;
namespace Tyuiu.MironenkoSE.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid ()
        {
            int[] n1 = new int[] { 1, 1, 1, 1, 1 };
            int[] n2 = new int[] { 1, 1, 1, 1, 1 };
            int[] n3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AdditionArrays(n1, n2);
            CollectionAssert.AreEqual(n3,res);



        }
    }
}
