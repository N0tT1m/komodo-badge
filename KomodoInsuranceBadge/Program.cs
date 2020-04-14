using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceBadge
{
    class Program
    {
        static void Main(string[] args)
        {
            BadgeRepository repo = new BadgeRepository();
            ProgramUI programUI = new ProgramUI(repo);
            programUI.Run();
        }
    }
}
