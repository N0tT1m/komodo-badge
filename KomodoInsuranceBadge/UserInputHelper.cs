using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceBadge
{
    class UserInputHelper
    {
        Badge badge = new Badge();
        int count = 0;

        public UserInputHelper()
        {

        }

        public Badge GetBadgeFromUser()
        {
            Badge newBadge = new Badge();
            newBadge.DoorNames = new List<string>();
            Console.WriteLine("What is the number on the badge: ");
            while (true)
            {
                try
                {
                    newBadge.BadgeID = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number");
                }
            }
            while (true)
            {
                if (count <= 0)
                {
                    Console.WriteLine("List a door that it needs access to: ");
                    newBadge.DoorNames.Add(Console.ReadLine());
                    count++;
                }
                else if (count > 0)
                {
                    Console.WriteLine("Any other doors (y/n)? ");
                    string door = Console.ReadLine();
                    if (door.ToLower() == "y")
                    {
                        Console.WriteLine("What door access would you like to add?");
                        door = Console.ReadLine();
                        newBadge.DoorNames.Add(door);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return newBadge;
        }

        public int? GetBadgeIDFromUser()
        {
            Console.WriteLine("What is the badge number to update? ");
            while (true)
            {
                try
                {
                    int badgeID = int.Parse(Console.ReadLine());
                    return badgeID;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You must enter a valid badge");
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid badge");
                }
            }
            return null;
        }
    }
}
