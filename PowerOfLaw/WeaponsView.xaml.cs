using Models;
using System.IO;
using System.Text;
using System.Windows;

namespace PowerOfLaw
{
    /// <summary>
    /// Логика взаимодействия для WeaponsView.xaml
    /// </summary>
    public partial class WeaponsView : Window
    {
        private string Path { get; set; }
        private void Save(object sender, RoutedEventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Path}/new.txt", false, System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                foreach (var col in dataGrid12.Columns)
                {
                    string c = col.Header.ToString();
                    if (c != "max_scatter") //
                        streamWriter.Write(c + "\t");
                    else
                        streamWriter.Write(c + "\n");
                }

                foreach (var item in dataGrid12.ItemsSource)
                    streamWriter.WriteLine(item.ToString());

                for (int i = 0; i < 6; i++)
                    streamWriter.WriteLine();
                for (int i = 0; i < 33; i++)
                    streamWriter.Write("\t");
                streamWriter.WriteLine();
            }
        }
        public WeaponsView(string path1)
        {
            InitializeComponent();
            ParsePeople(path1);
            Path = path1;
        }

        private void ParsePeople(string pathToDir)
        {
            WeaponsParser parse = new WeaponsParser(); // 
            using (StreamReader stream = new StreamReader($"{pathToDir}/weapons.txt", Encoding.GetEncoding("Windows-1251"))) //
            {
                dataGrid12.ItemsSource = parse.ParsePeople(stream);
            }
        }
    }

    public class WeaponsParser : Parse<Weapons> //
    {
        public override Weapons CreateObject(string[] items) // 
        {
            return new Weapons(items); //
        }
    }
}
