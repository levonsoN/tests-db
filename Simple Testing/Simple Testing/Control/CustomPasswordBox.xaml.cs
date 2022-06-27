using System;
using System.Security.Cryptography;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleTesting.Control
{
    public partial class CustomPasswordBox : UserControl
    {
        private const string salt = "anime";
        public string PasswordMD5 => GetMD5String(passwordBox.Text + salt);
        public string Password { get => passwordBox.Text; set => passwordBox.Text = value; }
        public int InnerTabIndex { set => passwordBox.TabIndex = value; }
        public event TextChangedEventHandler? PasswordChanged;
        public CustomPasswordBox()
           => InitializeComponent();

        private static string GetMD5String(string input)
        {
            using MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            return Convert.ToHexString(hashBytes)!.ToLower();
        }

        private void PasswordBoxPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space && passwordBox.IsFocused)
                e.Handled = true;
        }

        private void PasswordBoxTextChanged(object sender, TextChangedEventArgs e)
           => PasswordChanged?.Invoke(sender, e);
    }
}
