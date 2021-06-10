using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new List<string>
            {
               "add hack",
               "add hackerrank",
               "find hac",
               "find hak"
            };

            List<List<string>> queries = new List<List<string>>();

            for (int i = 0; i < commands.Count; i++)
            {
                queries.Add(commands[i].TrimEnd().Split(' ').ToList());
            }

            List<int> result = Result.contacts(queries);

            Console.WriteLine(String.Join("\n", result));
        }
    }

    class Result
    {
        private static StringCollection _names = new StringCollection();
        private static StringCollection _namesToSearch = new StringCollection();

        public static List<int> contacts(List<List<string>> queries)
        {
            var contactsMount = new List<int>();

            for (int i = 0; i < queries.Count; i++)
            {
                switch (queries[i][0].ToLower())
                {
                    case "add":
                        _names.Add(queries[i][1].ToLower());
                        break;

                    case "find":
                        _namesToSearch.Add(queries[i][1].ToLower());
                        break;
                }
            }

            for (int i = 0; i < _namesToSearch.Count; i++)
            {
                contactsMount.Add(SearchByName(_namesToSearch[i]));
            }

            return contactsMount;
        }

        private static int SearchByName(string name)
        {
            int mount = 0;

            for (int i = 0; i < _names.Count; i++)
            {
                if (_names[i].StartsWith(name))
                    mount++;
            }

            return mount;
        }
    }
}
