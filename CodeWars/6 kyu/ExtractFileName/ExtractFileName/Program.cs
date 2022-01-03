using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// https://www.codewars.com/kata/597770e98b4b340e5b000071/train/csharp

/*You have to extract a portion of the file name as follows:
    - Assume it will start with date represented as long number
    - Followed by an underscore
    - You'll have then a filename with an extension
    - it will always have an extra extension at the end

Example:
1_This_is_an_otherExample.mpg.OTHEREXTENSIONadasdassdassds34 => This_is_an_otherExample.mpg

Acceptable characters for random tests:
    abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_-0123456789
*/



namespace ExtractFileName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION";
            string filename2 = "1_This_is_an_otherExample.mpg.OTHEREXTENSIONadasdassdassds34";
            string filename3 = "1231231223123131_myFile.tar.gz2";
            Console.WriteLine(ExtractFileName(filename));
            Console.WriteLine(ExtractFileName(filename2));
            Console.WriteLine(ExtractFileName(filename3));

        }

        public static string ExtractFileName(string dirtFileName)
        {
           var matchNum = Regex.Match(dirtFileName, "([0-9]_)");

            if (matchNum.Success)
            {
                dirtFileName = dirtFileName.Substring(0, dirtFileName.LastIndexOf('.')).Remove(0, matchNum.Index + 2);
            }
            return dirtFileName;
        }
    }
}
