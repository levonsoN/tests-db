using SimpleTesting.Model;
using System.Windows;
using System.Windows.Controls;

namespace SimpleTesting.Windows
{
    public partial class RegisterAuthorWindow : EscEnterWindow
    {
        bool isName;
        bool isSurname;
        bool isPartronimyc;
        bool isPassword;
        bool isRepeatPassword;
        public RegisterAuthorWindow()
        {
            InitializeComponent();
            EnterAction += () =>
            {
                if (registerButton.IsEnabled)
                    RegisterButtonClick(null!, null!);
            };
            EscAction += Close;
        }

        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = nameTextBox.Text.Trim();
            surnameTextBox.Text = surnameTextBox.Text.Trim();
            patronimycTextBox.Text = patronimycTextBox.Text.Trim();
            if (passwordBox.Password != repeatPasswordBox.Password)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Author newAuthor = new()
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Patronimyc = patronimycTextBox.Text,
                Password = passwordBox.PasswordMD5
            };
            Utils.dbContext.Authors.Add(newAuthor);
            Utils.dbContext.SaveChanges();
            Close();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e) => Close();

        private void NameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            isName = nameTextBox.Text.Length > Utils.minFieldLength;
            RegisterButtonCheck();
        }

        private void SurnameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            isSurname = surnameTextBox.Text.Length > Utils.minFieldLength;
            RegisterButtonCheck();

        }

        private void PatronimycTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            isPartronimyc = patronimycTextBox.Text.Length > Utils.minFieldLength;
            RegisterButtonCheck();

        }

        private void PasswordBoxPasswordChanged(object sender, TextChangedEventArgs e)
        {
            isPassword = passwordBox.Password.Length > Utils.minFieldLength;
            RegisterButtonCheck();

        }

        private void RepeatPasswordBoxPasswordChanged(object sender, TextChangedEventArgs e)
        {
            isRepeatPassword = repeatPasswordBox.Password.Length > Utils.minFieldLength;
            RegisterButtonCheck();

        }
        private void RegisterButtonCheck() =>
            registerButton.IsEnabled = isName && isSurname && isPartronimyc && isPassword && isRepeatPassword;
    }
}
