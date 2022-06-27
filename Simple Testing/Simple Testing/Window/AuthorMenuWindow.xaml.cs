using SimpleTesting.Model;
using System.Windows;

namespace SimpleTesting.Windows
{
    public partial class AuthorMenuWindow : EscEnterWindow
    {
        private readonly Author author;
        public AuthorMenuWindow(Author author)
        {
            InitializeComponent();
            this.author = author;
            EscAction += Close;
        }
        private void LogOutButtonClick(object sender, RoutedEventArgs e) => Close();
        private void OpenTestsListButtonClick(object sender, RoutedEventArgs e)
        {
            TestsListWindow testsListWindow = new TestsListWindow(author);
            Hide();
            testsListWindow.Show();
            testsListWindow.Closed += (a, e) => Show();
        }
        private void EditProfileButtonClick(object sender, RoutedEventArgs e)
        {
            EditAuthorWindow editAuthorWindow = new EditAuthorWindow(author);
            Hide();
            editAuthorWindow.Show();
            editAuthorWindow.Closed += (a, e) =>
            {
                if (editAuthorWindow.IsDeleted)
                    Close();
                else
                    Show();
            };
        }
        private void WindowIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            authorSurnameLabel.Content = "Surname: " + author.Surname;
            authorNameLabel.Content = "Name: " + author.Name;
            authorPatronimycLabel.Content = "Patronimyc: " + author.Patronimyc;
        }
    }
}
