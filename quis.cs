using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

public class CircularView : Canvas
{
    public CircularView()
    {
        this.Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        double radius = Math.Min(this.ActualWidth, this.ActualHeight) / 2;
        EllipseGeometry clipGeometry = new EllipseGeometry(new Point(radius, radius), radius, radius);
        this.Clip = clipGeometry;
    }
}
