using System.Diagnostics;

namespace CarouselViewLoopBugReproduction;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void OnCarouselViewScrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
        Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
        Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
        Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
        Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
        Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
        Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
    }
}

