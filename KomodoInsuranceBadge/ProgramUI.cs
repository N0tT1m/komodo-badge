using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceBadge
{
    class ProgramUI
    {
        private UserInputHelper _userInputHelper = new UserInputHelper();
        private BadgeRepository _repo = new BadgeRepository();
        Badge badge = new Badge();

        bool running = true;

        public ProgramUI(BadgeRepository badgeRepository)
        {
            _repo = badgeRepository;
        }

        public void Run()
        {
            int userInput;

            Dictionary<int, List<string>> badges = _repo.GetAllBadges();

            while (running)
            {
                Console.WriteLine("Options for dealing with claims are listed below\n" +
                    "1: Create new badge\n" +
                    "2: Edit a badge\n" +
                    "3: List all Badges\n" +
                    "4: To exit the program");
                int.TryParse(Console.ReadLine(), out userInput);
                switch (userInput)
                {
                    case 1:
                        badge = _userInputHelper.GetBadgeFromUser();
                        _repo.CreateNewBadge(badge);
                        break;
                    case 2:
                        int badgeID = (int)_userInputHelper.GetBadgeIDFromUser();
                        if (badgeID != 1)
                            {
                            Console.WriteLine($"{badge.BadgeID} has access to doors {String.Join(", ", badge.DoorNames)}");
                            Console.WriteLine("What would you like to do?\n\t1. Remove a door\n\t2. Add a door");
                            int option = int.Parse(Console.ReadLine());
                            if (option == 1)
                            {
                                Console.WriteLine("Which door would you like to remove? ");
                                string doorAccessToRemove = Console.ReadLine();
                                _repo.UpdateBadge(option, doorAccessToRemove, badgeID);
                                Console.WriteLine("Door Removed");
                                Console.WriteLine($"{badge.BadgeID} {String.Join(", ", badge.DoorNames)}");
                            }
                            else if (option == 2)
                            {
                                Console.WriteLine("Which door would you like to add? ");
                                string doorToAdd = Console.ReadLine();
                                _repo.UpdateBadge(option, doorToAdd, badgeID);
                                Console.WriteLine("Door Added");
                                Console.WriteLine($"{badge.BadgeID} {String.Join(", ", badge.DoorNames)}");
                            }
                        }
                        break;
                    case 3:
                        badge.PrintBadge(badges, badge.DoorNames);
                        break;
                    case 4:
                        Console.WriteLine("BYEEE!");
                        Console.ReadLine();
                        break;

                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}