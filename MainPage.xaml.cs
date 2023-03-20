namespace ViewCellRendererBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		List<customObject> customObjects = new List<customObject>()
		{
			new customObject() {Name="Jimmy", Description="Tall"},
            new customObject() {Name="Bobby", Description="Small"},
            new customObject() {Name="Freddy", Description="Average"},
        };

		this.myListView.ItemsSource = customObjects;

    }
}

public class customObject
{
	public string Name { get; set; }
	public string Description { get; set; }
}

