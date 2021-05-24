using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLibraryStockManagement.Command;

namespace UnitTestSchoolLibrary
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddOrder_ValidQuantity_ReturnsTrue()
        {
            //Arrange
            var order = new IOrderReciever();
            var orderItem = new IOrderItemReciever();

            //Act
            bool result;
            if (new InsertOrderItem(orderItem, "0", "0", "1", "5", 6).CanExecute())
            {
                result = new InsertOrder(orderItem, order, "0", "1").CanExecute();
            }
            else
            {
                result = false;
            }
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddOrder_InValidQuantity_ReturnsFalse()
        {
            //Arrange
            var order = new IOrderReciever();
            var orderItem = new IOrderItemReciever();

            //Act
            bool result = false;
            if (new InsertOrderItem(orderItem, "0", "0", ".", "5", 6).CanExecute())
            {
                result = true;
            }

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddOrder_LessQuantityThanAvailable_Returns()
        {
            //Arrange
            var order = new IOrderReciever();
            var orderItem = new IOrderItemReciever();

            //Act
            bool result = false;
            if (new InsertOrderItem(orderItem, "0", "0", "0", "10", 6).CanExecute())
            {
                result = true;
            }
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddOrder_MoreQuantityThanAvailable_ReturnsTrue()
        {
            //Arrange
            var order = new IOrderReciever();
            var orderItem = new IOrderItemReciever();

            //Act
            bool result = false;
            if (new InsertOrderItem(orderItem, "0", "0", "1000", "10", 6).CanExecute())
            {
                result = true;
            }
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddOrder_EmptyQuantity_ReturnsTrue()
        {
            //Arrange
            var order = new IOrderReciever();
            var orderItem = new IOrderItemReciever();

            //Act
            bool result = false;
            if (new InsertOrderItem(orderItem, "0", "0", "", "10", 6).CanExecute())
            {
                result = true;
            }
            //Assert
            Assert.IsFalse(result);
        }
    }
}
