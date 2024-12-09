using System.Windows;

namespace G24W1501WPFDataGrid;
public partial class MainWindow : Window
{
    protected List<GundamModel> GundamList = new List<GundamModel>();
    public MainWindow()
    {
        InitializeComponent();

        GundamGrid.ItemsSource=GundamList;

        GundamList.Add(new GundamModel("건담", "Rx-78-2", "연방군"));
        GundamList.Add(new GundamModel("자쿠||", "MS-06", "지온군"));

    }

    public void OnAdd(object sender, RoutedEventArgs e)
    {
        GundamList.Add(new GundamModel("건탱크", "RX-75-4", "연방군"));
    }
}