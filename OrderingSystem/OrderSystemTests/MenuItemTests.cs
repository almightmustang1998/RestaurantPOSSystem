using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderingSystem;

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrderingSystem.Tests
{
    //Wasn't really sure what to do for unit testing because most of our porgram is built through a variety of Database calls
    [TestClass()]
    public class MenuItemTests
    {
        Order o = new Order();
        MenuItem I = new MenuItem();
        string Role = GlobalData.role;
        [TestMethod()]
        public void CreatingMenuItem()
        {
            MenuItem newItem = new MenuItem("Bread Sticks", 10, MenuCategory.Appetizer, MenuType.Lunch);
            Assert.AreEqual(MenuType.Lunch, newItem.MenuType);
            Assert.AreEqual("Bread Sticks", newItem.Description);
            Assert.AreEqual(MenuCategory.Appetizer, newItem.Category);
            Assert.AreEqual(10, newItem.Price);

        }


    }
}
