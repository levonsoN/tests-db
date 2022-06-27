using SimpleTesting.Model;
using SimpleTesting.Windows;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SimpleTesting
{
    public partial class MainWindow : EscEnterWindow
    {
        private List<Author> authors = new();
        public MainWindow()
        {
            InitializeComponent();
            EnterAction += () =>
            {
                if (logInButton.IsEnabled)
                    LogInButtonClick(null!, null!);
            };
            EscAction += Close;
        }

        private void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            Author author = authors[namesComboBox.SelectedIndex];
            if (author.Password != passwordBox.PasswordMD5)
            {
                MessageBox.Show("Incorrect password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            AuthorMenuWindow authorMenuWindow = new AuthorMenuWindow(author);
            Hide();
            authorMenuWindow.Show();
            authorMenuWindow.Closed += (s, e) => Show();
        }

        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            RegisterAuthorWindow registerWindow = new RegisterAuthorWindow();
            Hide();
            registerWindow.Show();
            registerWindow.Closed += (s, e) => Show();
        }

        private void TakeTestButtonClick(object sender, RoutedEventArgs e)
        {
        }

        private void WindowIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            passwordBox.Password = string.Empty;
            namesComboBox.Items.Clear();
            authors.Clear();
            logInButton.IsEnabled = false;
            foreach (Author author in Utils.dbContext.Authors)
            {
                namesComboBox.Items.Add($"{author.AuthorId}: {author.Surname} {author.Name} {author.Patronimyc}");
                authors.Add(author);
            }

            bool enableComponents;
            if (namesComboBox.Items.Count > 0)
            {
                enableComponents = true;
                namesComboBox.SelectedIndex = authors.Count - 1;
            }
            else
            {
                enableComponents = false;
                namesComboBox.Items.Add("<none>");
                namesComboBox.SelectedIndex = 0;
            }
            namesComboBox.IsEnabled = passwordBox.IsEnabled = nameLabel.IsEnabled
                = takeTestButton.IsEnabled = passwordLabel.IsEnabled = enableComponents;
        }
        private void PasswordBoxPasswordChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        => logInButton.IsEnabled = passwordBox.Password.Length > 2;
    }
}
