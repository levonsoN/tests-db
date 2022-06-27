using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleTesting.Windows
{
    public abstract class EscEnterWindow : Window
    {
        public event Action? EnterAction;
        public event Action? EscAction;
        public EscEnterWindow()
        {
            PreviewKeyDown += EscEnterWindowPreviewKeyDown;
        }

        private void EscEnterWindowPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                EnterAction?.Invoke();
            else if (e.Key == Key.Escape)
                EscAction?.Invoke();
        }
    }
}
