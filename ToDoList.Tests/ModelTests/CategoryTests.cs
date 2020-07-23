using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
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
      Category newCategory = new Category("test category");// ID 1
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string name = "Test Category";
      Category newCategory = new Category(name); // ID 2

      // Act
      string result = newCategory.Name;

      // Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsCategoryID_Int()
    {
      // Arrange
      string name = "Test Category";
      Category newCategory = new Category(name);// ID 3
      // Act
      int result = newCategory.Id;
      // Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      // arrange
      string name01 = "Work";
      string name02 = "School";
      Category newCategory1 = new Category(name01);
      Category newCategory2 = new Category(name02);
      List<Category> newList = new List<Category> { newCategory1, newCategory2 };
      // Act
      List<Category> result = Category.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      // Arrange
      string name01 = "Work";
      string name02 = "School";
      Category newCategory1 = new Category(name01);
      Category newCategory2 = new Category(name02);
      // Act
      Category result = Category.Find(2);
      // Assert
      Assert.AreEqual(newCategory2, result);
    }
  }
}