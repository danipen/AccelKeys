using Avalonia.Controls;
using Avalonia.Media;

namespace AccelKeys
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mUndoButton.Click += MUndoButton_Click;
        }

        private void MUndoButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (this.Background == Brushes.Red)
                this.Background = Brushes.White;
            else
                this.Background = Brushes.Red;
        }
    }
}