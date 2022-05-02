using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegeHXW
{
    class Tasks
    {
        public void Task1()
        {
            string str = "apple - $4, salad - $43, kivi - $1.";
            int cost = 0;
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(str);
            foreach (Match item in matches)
                cost += int.Parse(item.Value);
            Console.WriteLine($"{str}\nCost: {cost}$");
        }

        public void Task2()
        {
            string str = DateTime.Now.ToString("d");
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(str);

            List<string> date = new List<string>();
            date.Add(matches[0].ToString());
            date.Add(matches[1].ToString());
            date.Add(matches[2].ToString());
            Console.WriteLine($"{date[0]}-{date[1]}-{date[2]}г.");
        }
        public void Task3()
        {
            var pattern = @"\w+[-`]?\w+";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            string str = "слово \"слова в кавычках\" тере1-тере1 тере2--тере2 апостро`ф";
            MatchCollection matches = regex.Matches(str);
            foreach (Match item in matches)
                Console.WriteLine(item.Value.ToString());

        }
        public void Task4()
        {
            string str = "Extra       spaces.Sentence      .Sentence";
            var spacePattern = @"\s{2,}";
            var dotPattern = @"[\.]+[\s]*";
            str = Regex.Replace(str, spacePattern, " ");
            str = Regex.Replace(str, dotPattern, ".  ");
            Console.WriteLine(str);

        }
    }
}
