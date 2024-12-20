using System.Windows;
using System.Windows.Controls;

namespace GUI_Demo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDoSth_Click(object sender, RoutedEventArgs e)
        {
            var name = txtInput.Text;
            var anrede = GetAnrede(cbxOptions);

            MessageBox.Show($"Hallo {anrede} {name}");
        }

        private string GetAnrede(ComboBox cbxOptions)
        {
            Enum.TryParse(cbxOptions.SelectedValue.ToString(), out Sex selected);
            switch (selected)
            {
                case Sex.Male:
                    return "Herr";
                case Sex.Female:
                    return "Frau";
                default:
                    return "";
            }
        }
    }

    enum Sex
    {
        Male,
        Female,
        Divers
    }
}