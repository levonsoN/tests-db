using SimpleTesting.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleTesting.Windows
{
    public partial class EditAuthorWindow : EscEnterWindow
    {
        public bool IsDeleted { get; private set; } = false;
        bool isName;
        bool isSurname;
        bool isPartronimyc;
        bool isPassword;
        bool isRepeatPassword;

        private readonly Author author;
        public EditAuthorWindow(Author author)
        {
            InitializeComponent();
            this.author = author;
            EnterAction += () =>
            {
                if (saveButton.IsEnabled)
                    SaveButtonClick(null!, null!);
            };
            EscAction += Close;
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e) => Close();

        private void NameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            isName = nameTextBox.Text.Length > Utils.minFieldLength;
            SaveButtonCheck();
        }

        private void SurnameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            isSurname = surnameTextBox.Text.Length > Utils.minFieldLength;
            SaveButtonCheck();

        }

        private void PatronimycTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            isPartronimyc = patronimycTextBox.Text.Length > Utils.minFieldLength;
            SaveButtonCheck();

        }

        private void PasswordBoxPasswordChanged(object sender, TextChangedEventArgs e)
        {
            isPassword = passwordBox.Password.Length > Utils.minFieldLength;
            SaveButtonCheck();
        }

        private void RepeatPasswordBoxPasswordChanged(object sender, TextChangedEventArgs e)
        {
            isRepeatPassword = repeatPasswordBox.Password.Length > Utils.minFieldLength;
            SaveButtonCheck();
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = nameTextBox.Text.Trim();
            surnameTextBox.Text = surnameTextBox.Text.Trim();
            patronimycTextBox.Text = patronimycTextBox.Text.Trim();

            author.Name = nameTextBox.Text;
            author.Surname = surnameTextBox.Text;
            author.Patronimyc = patronimycTextBox.Text;
            if (changePasswordCheckBox.IsChecked!.Value)
            {
                if (passwordBox.Password != repeatPasswordBox.Password)
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                author.Password = passwordBox.PasswordMD5;
            }
            Utils.dbContext.SaveChanges();
            Close();
        }
        private void SaveButtonCheck() =>
         saveButton.IsEnabled = isName && isSurname && isPartronimyc && ((isPassword && isRepeatPassword) || !changePasswordCheckBox.IsChecked!.Value);

        private void WindowIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            nameTextBox.Text = author.Name;
            surnameTextBox.Text = author.Surname;
            patronimycTextBox.Text = author.Patronimyc;
            saveButton.IsEnabled = false;
        }

        private void ChangePasswordCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            passwordBox.IsEnabled = passwordLabel.IsEnabled = repeatPasswordBox.IsEnabled = repeatPasswordLabel.IsEnabled = changePasswordCheckBox.IsChecked!.Value;
            SaveButtonCheck();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("You are going to delete the author's profile.\n" +
                 "All tests by this author will be deleted aswell." +
                 "\nAre you shure?", "Profile Deletion", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Utils.dbContext.Authors.Remove(author);
                Utils.dbContext.SaveChanges();
                IsDeleted = true;
                Close();
            }
        }
    }
}
