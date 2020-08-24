using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PowerOfLaw
{
    public abstract class Parse<T> where T: class
    {
        public abstract T CreateObject(string[] items);
        public List<T> ParsePeople(StreamReader stream)
        {
            string[] headers = stream.ReadLine().Split('\t');

            List<T> listData = new List<T>();
            while (!stream.EndOfStream)
            {
                string[] row = stream.ReadLine().Split('\t');
                if (row.Length == 1 && row[0] == string.Empty) break;
                while (row.Length < headers.Length)
                {
                    string[] buff = stream.ReadLine().Split('\t');
                    if (Regex.IsMatch(buff[0], @"[А-Яа-я]"))
                    {
                        row[row.Length - 1] += $"\n{buff[0]}";
                        if (buff.Length > 1)
                        {
                            List<string> list = new List<string>(buff);
                            list.RemoveAt(0);
                            row = row.Concat(list).ToArray();
                        }
                    }
                }

                listData.Add(CreateObject(row));
            }
            return listData;
        }
    }
}
