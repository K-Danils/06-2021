using System;
using System.Collections.Generic;
using Hierarchy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HierarchyTests
{
    [TestClass]
    public class AnimalCreatorTest
    {
        AnimalCreator _target;

        [TestMethod]
        public void ProccessInformation_CatGray1HomePersian_ReturnsAllAtributesRight()
        {
            // Arrange
            _target = new AnimalCreator();

            // Act
            _target.ProccessInformation("Cat Gray 1.1 Home Persian");

            // Assert
            Assert.AreEqual("Cat", _target.Attributes[0]);
            Assert.AreEqual("Gray", _target.Attributes[1]);
            Assert.AreEqual("1.1", _target.Attributes[2]);
            Assert.AreEqual("Home", _target.Attributes[3]);
            Assert.AreEqual("Persian", _target.Attributes[4]);
        }

        [TestMethod]
        public void ProccessInformation_CatGray1HomePersianSixthVariable_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();
            var exception = Assert.ThrowsException<Exception>(() => _target.ProccessInformation("Cat Gray 1.1 Home Persian somethingElse"));

            // Assert
            Assert.AreEqual(exception.Message, "Not enough / too much information has been given");
        }

        [TestMethod]
        public void ProccessInformation_CatGray1HomePersian_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();
            var exception = Assert.ThrowsException<Exception>(() => _target.ProccessInformation("Cat Gray 1.1 Home"));

            // Assert
            Assert.AreEqual(exception.Message, "Not enough / too much information has been given");
        }

        [TestMethod]
        public void ProccessInformation_TigerGray_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();
            var exception = Assert.ThrowsException<Exception>(() => _target.ProccessInformation("Tiger Gray"));

            // Assert
            Assert.AreEqual(exception.Message, "Not enough / too much information has been given");

        }

        [TestMethod]
        public void CreateNewAnimal_CatAndTiger_AnimalsListShouldHaveCatAndTiger()
        {
            // Arrange
            _target = new AnimalCreator();

            // Act
            _target.ProccessInformation("Cat Gray 1.1 Home Persian");
            _target.CreateNewAnimal();
            _target.ProccessInformation("Tiger Typcho 167.7 Asia");
            _target.CreateNewAnimal();

            // Assert
            Assert.IsTrue(_target.Animals[0] is Cat);
            Assert.IsTrue(_target.Animals[1] is Tiger);
        }

        [TestMethod]
        public void CreateNewAnimal_Donkey_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();

            _target.ProccessInformation("Donkey Gray 100.1 Yard");

            var exception = Assert.ThrowsException<Exception>(() => _target.CreateNewAnimal());

            // Assert
            Assert.AreEqual(exception.Message, "Animal not found");
        }

        [TestMethod]
        public void GetAnimalInformation_CatClass_ReturnsCatInformation()
        {
            // Arrange
            _target = new AnimalCreator();
            string expectedInformation = "Cat [Gray, Persian, 1.1, Home, 0]";

            // Act
            _target.ProccessInformation("Cat Gray 1.1 Home Persian");
            _target.CreateNewAnimal();

            // Assert
            Assert.AreEqual(expectedInformation, _target.GetAnimalInformation());
        }

        [TestMethod]
        public void GetAnimalInformation_MouseClass_ReturnsMouseInformation()
        {
            // Arrange
            _target = new AnimalCreator();
            string expectedInformation = "Mouse [Gray, 0.1, House, 0]";

            // Act
            _target.ProccessInformation("Mouse Gray 0.1 House");
            _target.CreateNewAnimal();

            // Assert
            Assert.AreEqual(expectedInformation, _target.GetAnimalInformation());
        }

        [TestMethod]
        public void FeedAnimal_CatVegetable4_ReturnsFoodEatenCat4()
        {
            // Arrange
            _target = new AnimalCreator();

            // Act
            _target.ProccessInformation("Cat Gray 1.1 Home Persian");
            _target.CreateNewAnimal();
            _target.FeedAnimal("Vegetable 4");

            // Assert
            Assert.AreEqual(4, _target.Animals[0].FoodEaten);
        }

        [TestMethod]
        public void FeedAnimal_TigerVegetable4_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();

            // Act
            _target.ProccessInformation("Tiger Typcho 167.7 Asia");
            _target.CreateNewAnimal();

            var exception = Assert.ThrowsException<Exception>(() => _target.FeedAnimal("Vegetable 4"));

            // Assert
            Assert.AreEqual(exception.Message, "Tiger does not eat that type of food!");
        }

        [TestMethod]
        public void FeedAnimal_MouseMeat4_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();

            // Act
            _target.ProccessInformation("Mouse Gray 0.1 House");
            _target.CreateNewAnimal();

            var exception = Assert.ThrowsException<Exception>(() => _target.FeedAnimal("Meat 4"));

            // Assert
            Assert.AreEqual(exception.Message, "Mouse does not eat that type of food!");
        }

        [TestMethod]
        public void FeedAnimal_TryToFeedFruits_ThrowsException()
        {
            // Arrange
            _target = new AnimalCreator();

            // Act
            _target.ProccessInformation("Tiger Typcho 167.7 Asia");
            _target.CreateNewAnimal();

            var exception = Assert.ThrowsException<Exception>(() => _target.FeedAnimal("Fruits 4"));

            // Assert
            Assert.AreEqual(exception.Message, "Incorrect food was given");
        }
    }
}
