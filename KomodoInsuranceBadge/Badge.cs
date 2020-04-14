using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceBadge
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }

        public void PrintBadge(Dictionary<int, List<string>> badges, List<string> listOfDoorAccess)
        {
            Console.WriteLine($"{"Badge #", -15} {"Door Access"}");
            foreach (KeyValuePair<int, List<string>> badge in badges)
            {
                string doorAccess = String.Join(",", badge.Value);

                string keyValueString = string.Format("{0, -15} {1}", badge.Key, String.Join(", ", doorAccess));
                Console.WriteLine(keyValueString);
            }
        }

        public Badge()
        {

        }
    }
}
