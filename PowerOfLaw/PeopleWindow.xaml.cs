using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using Models;

namespace PowerOfLaw
{
    /// <summary>
    /// Логика взаимодействия для People.xaml
    /// </summary>
    public partial class PeopleWindow : Window
    {
        private string Path { get; set; }
        private void Save(object sender, RoutedEventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Path}/people.txt", false, System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                foreach (var col in dataGrid1.Columns)
                {
                    string c = col.Header.ToString();
                    if (c != "can_use_scuba")
                        streamWriter.Write(c + "\t");
                    else
                        streamWriter.Write(c + "\n");
                }

                foreach (var item in dataGrid1.ItemsSource)
                    streamWriter.WriteLine(item.ToString());
            }
        }
        public PeopleWindow(string path1)
        {
            InitializeComponent();
            ParsePeople(path1);
            Path = path1;
        }

        private void ParsePeople(string pathToDir)
        {
            PeopleParser parse = new PeopleParser();
            using (var stream = new StreamReader($"{pathToDir}/people.txt", System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                dataGrid1.ItemsSource = parse.ParsePeople(stream);
            }
        }
    }

    public class PeopleParser : Parse<People>
    {
        public override People CreateObject(string[] items)
        {
            return new People(items);
        }
    }
}
