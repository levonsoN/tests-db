using SimpleTesting.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace SimpleTesting.Windows
{
    public partial class TestsListWindow : Window
    {
        readonly Author author;
        public TestsListWindow(Author author)
        {
            InitializeComponent();
            this.author = author;
            authorTextBlock.Content = $"Author: {author.Surname} {author.Name} {author.Patronimyc}";
        }

        private void WindowIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }
        private void CreateTestButtonClick(object sender, RoutedEventArgs e)
        {
            CreateTestWindow createTestWindow = new CreateTestWindow();
            Hide();
            createTestWindow.Show();
            createTestWindow.Closed += (a, e) => Show();
        }
    }
}
