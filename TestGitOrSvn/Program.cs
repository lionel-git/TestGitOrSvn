using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitOrSvn
{
    class Program
    {

        static List<string>_testDir = new List<string>() { @"..", @".", @"c:\tmp\diff", @"D:\my_projects\Solitaire\Solitaire", @"D:\svn\MyAlarm\MyAlarm" };

        static void Main(string[] args)
        {
            try
            {
                foreach (var dir in _testDir)
                {
                    string absolute = Path.GetFullPath(dir);
                    Console.WriteLine($"{dir} {absolute} => {CheckDirectory.GetDirectoryType(absolute)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
