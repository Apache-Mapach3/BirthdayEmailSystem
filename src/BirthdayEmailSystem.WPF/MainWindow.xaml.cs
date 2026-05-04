using System.Windows;
using BirthdayEmailSystem.WPF.ViewModels;

namespace BirthdayEmailSystem.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}