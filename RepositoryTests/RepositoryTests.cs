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

            List<string> actual = repo.GetBadgeByID(123);
            List<string> expected = new List<string>()
            {
                "A5",
                "A4"
            };
            Assert.AreEqual(expected, actual);
        }
    }

}
