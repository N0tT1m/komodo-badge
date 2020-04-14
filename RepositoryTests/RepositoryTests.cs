using System;
using System.Collections.Generic;
using KomodoInsuranceBadge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoRepositoryTests
{
    [TestClass]
    public class RepositoryTests
    {
        BadgeRepository repo = new BadgeRepository();
        Badge badge = new Badge();

        [TestMethod]
        public void CreateBadge_ShouldAddNewBadge()
        {
            badge.BadgeID = 123;
            badge.DoorNames = new List<string>()
            {
                "A5",
                "A4"
            };

            bool wasCreated = repo.CreateNewBadge(badge);
            Assert.IsTrue(wasCreated);
        }
        [TestMethod]
        public void GetBadgeByID_ShouldReturnFirstBadge()
        {
            badge.BadgeID = 123;
            badge.DoorNames = new List<string>()
            {
                "A5",
                "A4"
            };

            List<string> actual = badge.DoorNames;
            List<string> expected = badge.DoorNames;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateBadge_ShouldRemoveDoor()
        {
            badge.BadgeID = 123;
            badge.DoorNames = new List<string>()
            {
                "A5",
                "A4"
            };

            bool doorUpdate = (bool)repo.UpdateBadge(1, "A5", 123);
            Assert.IsTrue(doorUpdate);
        }

        [TestMethod]
        public void GetAllBadges_ReturnSameDictionary()
        {
            Dictionary<int, List<string>> dictionary1 = repo.GetAllBadges();
            Dictionary<int, List<string>> dictionary2 = repo.GetAllBadges();

            Assert.AreEqual(dictionary1, dictionary2);
        }
    }
}
