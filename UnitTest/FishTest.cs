using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoFish.WebUI.Models;


namespace UnitTest
{
    public class FishTest 
    {
        [TestMethod]
        public void Can_Add_New_Fish()
        {

         
            FishData f1 = new FishData { FishID = 1, Weight = "f1" };
            FishData f2 = new FishData { FishID = 2, Weight = "f2" };

            
            Favorites target = new Favorites();

            
            //target.Type(f1, 1);
            target.AddItem(f2);
            //Fish[] results = target.Lines.ToArray();

            //// Assert
            //Assert.AreEqual(results.Length, 2);
            //Assert.AreEqual(results[0].FishID, f1);
            //Assert.AreEqual(results[1].FishID, f2);
        }

    }
}
