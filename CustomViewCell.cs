namespace ViewCellRendererBug;

public class CustomViewCell : ViewCell
{
    public static readonly BindableProperty SelectedBackgroundColorProperty = BindableProperty.Create("SelectedBackgroundColor", typeof(Color), typeof(CustomViewCell), Colors.Transparent);

    public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create("IsSelected", typeof(bool), typeof(CustomViewCell), false);

    public Color SelectedBackgroundColor
    {
        get { return (Color)this.GetValue(SelectedBackgroundColorProperty); }
        set { this.SetValue(SelectedBackgroundColorProperty, value); }
    }

    public bool IsSelected
    {
        get { return (bool)this.GetValue(IsSelectedProperty); }
        set { this.SetValue(IsSelectedProperty, value); }
    }
}
