using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PowerOfLaw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public string PathToDir = "C:/Users/karasyuk.2018/Desktop";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowDialog(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку с файлами";
            folderDialog.ShowDialog();
            PathToDir = folderDialog.SelectedPath;
            InputPath.Text = PathToDir;
        }

        private void ShowPeopleWindow(object sender, RoutedEventArgs e) 
        {
            PathToDir = InputPath.Text;
            if (PathToDir != string.Empty)
            {
                PeopleWindow people = new PeopleWindow(PathToDir);
                people.Show();
            }
        }
        private void ShowTechWindow(object sender, RoutedEventArgs e)
        {
            PathToDir = InputPath.Text;
            if (PathToDir != string.Empty)
            {
                TechView tech = new TechView(PathToDir);
                tech.Show();
            }
        }
        private void ShowArmorsWindow(object sender, RoutedEventArgs e)
        {
            PathToDir = InputPath.Text;
            if (PathToDir != string.Empty)
            {
                ArmorsView armors = new ArmorsView(PathToDir);
                armors.Show();
            }
        }
        private void ShowWeaponsWindow(object sender, RoutedEventArgs e)
        {
            PathToDir = InputPath.Text;
            if (PathToDir != string.Empty)
            {
                WeaponsView armors = new WeaponsView(PathToDir);
                armors.Show();
            }
        }
    }
}
