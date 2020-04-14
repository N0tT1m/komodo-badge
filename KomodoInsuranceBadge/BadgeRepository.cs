using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceBadge
{
    public class BadgeRepository
    {
        Badge badge = new Badge();
        UserInputHelper userInputHelper = new UserInputHelper();
        private Dictionary<int, List<string>> badges = new Dictionary<int, List<string>>();

        public bool CreateNewBadge(Badge badgeToCreate)
        {
            int startingCount = badges.Count;
            badges.Add(badgeToCreate.BadgeID, badgeToCreate.DoorNames);
            bool wasCreated = (badges.Count > startingCount);
            return wasCreated;
        }

        public List<string> GetBadgeByID(int badgeID)
        {
            foreach (var key in badges.Keys)
            {
                if (key == badgeID)
                {
                    return badges[badgeID];
                }
            }
            return null;
        }

        public void UpdateBadge(int option, string door, int badgeID)
        {
            badge.DoorNames = GetBadgeByID(badgeID);
            if (option == 1)
            {
                badge.DoorNames.Remove(door);
            }
            if (option == 2)
            {
                badge.DoorNames.Add(door);
            }
        }

        public Dictionary<int, List<string>> GetAllBadges()
        {
            return badges;
        }
    }
}
