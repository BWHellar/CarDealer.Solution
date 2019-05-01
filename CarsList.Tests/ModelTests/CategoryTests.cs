using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsList.Models;
using System.Collections.Generic;
using System;

namespace CarsList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {

    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      string result = newCategory.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);

      //Act
      int result = newCategory.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      //Arrange
      string car01 = "Honda";
      string car02 = "Mazda";
      Category newCategory1 = new Category(car01);
      Category newCategory2 = new Category(car02);
      List<Category> newList = new List<Category> { newCategory1, newCategory2 };

      //Act
      List<Category> result = Category.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      //Arrange
      string car01 = "Ford";
      string car02 = "Lotus";
      Category newCategory1 = new Category(car01);
      Category newCategory2 = new Category(car02);

      //Act
      Category result = Category.Find(2);

      //Assert
      Assert.AreEqual(newCategory2, result);
    }

    [TestMethod]
    public void GetItems_ReturnsEmptyItemList_ItemList()
    {
      //Arrange
      string name = "Car";
      Category newCategory = new Category(name);
      List<Item> newList = new List<Item> { };

      //Act
      List<Item> result = newCategory.GetItems();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }



  }
}
