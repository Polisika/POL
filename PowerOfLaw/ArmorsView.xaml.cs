using Models;
using System.IO;
using System.Text;
using System.Windows;

namespace PowerOfLaw
{
    /// <summary>
    /// Логика взаимодействия для ArmorsView.xaml
    /// </summary>
    public partial class ArmorsView : Window
    {
        private string Path { get; set; }
        private void Save(object sender, RoutedEventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Path}/armors.txt", false, System.Text.Encoding.GetEncoding("Windows-1251")))
            {
                foreach (var col in dataGrid12.Columns)
                {
                    string c = col.Header.ToString();
                    if (c != "min_rank") //
                        streamWriter.Write(c + "\t");
                    else
                        streamWriter.Write(c + "\n");
                }

                foreach (var item in dataGrid12.ItemsSource)
                    streamWriter.WriteLine(item.ToString());
            }
        }
        public ArmorsView(string path1)
        {
            InitializeComponent();
            ParsePeople(path1);
            Path = path1;
        }

        private void ParsePeople(string pathToDir)
        {
            ArmorsParser parse = new ArmorsParser(); // 
            using (StreamReader stream = new StreamReader($"{pathToDir}/armors.txt", Encoding.GetEncoding("Windows-1251"))) //
            {
                dataGrid12.ItemsSource = parse.ParsePeople(stream);
            }
        }
    }

    public class ArmorsParser : Parse<Armors> //
    {
        public override Armors CreateObject(string[] items) // 
        {
            return new Armors(items); //
        }
    }
}
