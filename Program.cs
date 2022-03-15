using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    static class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja(222);
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            mees.hoone = majake;
            majake.NaitaINFO();
            mees.NaitaInfo();
            Console.ReadLine();
        }
    }
}
