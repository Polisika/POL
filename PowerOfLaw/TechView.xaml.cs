using Models;
using System.IO;
using System.Text;
using System.Windows;

namespace PowerOfLaw
{
    /// <summary>
    /// Логика взаимодействия для TechView.xaml
    /// </summary>
    public partial class TechView : Window
    {
        private string Path { get; set; }
        private void Save(object sender, RoutedEventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Path}/armors.txt", false, System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                foreach (var col in dataGrid1.Columns)
                {
                    string c = col.Header.ToString();
                    if (c != "view_bone")
                        streamWriter.Write(c + "\t");
                    else
                        streamWriter.Write(c + "\n");
                }

                foreach (var item in dataGrid1.ItemsSource)
                    streamWriter.WriteLine(item.ToString());
            }
        }
        public TechView(string path1)
        {
            InitializeComponent();
            ParsePeople(path1);
            Path = path1;
        }

        private void ParsePeople(string pathToDir)
        {
            TechParser parse = new TechParser();
            using (StreamReader stream = new StreamReader($"{pathToDir}/tech.txt", Encoding.GetEncoding("Windows-1251")))
            {
                dataGrid1.ItemsSource = parse.ParsePeople(stream);
            }
        }
    }

    public class TechParser : Parse<Tech>
    {
        public override Tech CreateObject(string[] items)
        {
            return new Tech(items);
        }
    }
}
