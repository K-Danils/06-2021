using System;
using System.Collections.Generic;
using FlightPlanner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsTests
{
    [TestClass]
    public class FlightPlannerTest
    {
        Flights _target;

        [TestMethod]
        public void ConvertFlightsToDictionary_GivenCorrectString_EveryKeyUniqueAndHasValueNoDuplicates()
        {
            _target = new Flights();
            string flights = "1 -> 123\n1 -> 123\n2 -> 23\n2 -> 32";

            _target.ConvertFlightsToDictionary(flights);

            Dictionary<string, string> expectedResult = new Dictionary<string, string>()
            {
                {"1","123"},
                {"2","23, 32"},
            };

            CollectionAssert.AreEqual(expectedResult, _target.FlightsDict);
        }

        [TestMethod]
        public void ConvertFlightsToDictionary_IncorrectlyFormatedText_ThrowsException()
        {
            _target = new Flights();
            string flights = "1 -> 123\n1 -> 123\n2 - 23\n2 -> 32";
            var exception = Assert.ThrowsException<Exception>(() =>  _target.ConvertFlightsToDictionary(flights));

            Assert.AreEqual(exception.Message, "Incorrect flight text format was given");
        }

        [TestMethod]
        public void ConvertFlightsToDictionary_StringEmptyAndNull_ThrowsException()
        {
            _target = new Flights();
            string flights = "";

            Assert.ThrowsException<ArgumentNullException>(() => _target.ConvertFlightsToDictionary(flights));
            Assert.ThrowsException<ArgumentNullException>(() => _target.ConvertFlightsToDictionary(null));
        }

        [TestMethod]
        public void VisitCitiesAndGetVisitedCities_GivenFlightRoute_ReturnsListOfVisitedCities()
        {
            _target = new Flights();
            
            _target.VisitCity("San Jose");
            _target.VisitCity("Denver");
            _target.VisitCity("New York");
            _target.VisitCity("Denver");

            Assert.AreEqual("San Jose -> Denver -> New York -> Denver", _target.GetVisitedCities());
        }

        [TestMethod]
        public void VisitCitiesAndGetVisitedCities_StringEmptyAndNull_ThrowsException()
        {
            _target = new Flights();

            Assert.ThrowsException<ArgumentNullException>(() => _target.VisitCity(null));
            Assert.ThrowsException<ArgumentNullException>(() => _target.VisitCity(""));
        }

        [TestMethod]
        public void GetAvailableCities_SanJose_ReturnsDenver_NewYork()
        {
            _target = new Flights();
            string text = "San Jose -> Denver\nNew York -> Denver";

            _target.ConvertFlightsToDictionary(text);

            Assert.AreEqual("Denver", _target.GetAvailableCities("San Jose"));
        }

        [TestMethod]
        public void GetAvailableCities_NonExistingCity_ThrowsException()
        {
            _target = new Flights();
            string flights = "1 -> 123\n1 -> 123\n2 -> 23\n2 -> 32";

            _target.ConvertFlightsToDictionary(flights);

            var exception = Assert.ThrowsException<Exception>(() => _target.GetAvailableCities("3"));

            Assert.AreEqual(exception.Message, "Non defined city given");
        }

        [TestMethod]
        public void GetAllAvailableFlights_FlightList_ReturnsAllFlightsAndDestinations()
        {
            _target = new Flights();

            string text = "San Jose -> Denver\nNew York -> Denver\nNew York -> San Francisco";
            
            _target.ConvertFlightsToDictionary(text);

            string actualText = _target.GetAllAvailableFlights();

            Assert.AreEqual("San Jose -> Denver\nNew York -> Denver, San Francisco\n",actualText);
        }
    }
}
