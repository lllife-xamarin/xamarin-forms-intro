### Create solution

- Multiplatform -> Xamarin.Forms -> Forms App (C#/F#)


### Create `ContentPage` with CSharp

`StackLayoutExample.cs`

```csharp
public class StackLayoutExample : ContentPage
{
    public StackLayoutExample ()
    {
        Padding = new Thickness (20);
        var red = new Label {
            Text = "Stop", BackgroundColor = Color.Red, FontSize = 20
        };

        var yellow = new Label {
            Text = "Slow down", BackgroundColor = Color.Yellow, FontSize = 20
        };

        var green = new Label {
            Text = "Go", BackgroundColor = Color.Green, FontSize = 20
        };

        Content = new StackLayout { 
            Spacing = 10,
            Children = { red, yellow, green }
        };
    }
}
```

### Link

- https://developer.xamarin.com/guides/xamarin-forms/getting-started/introduction-to-xamarin-forms

`Intro.cs`

```csharp
public class App : Application
{
    public App ()
    {
        // The root page of your application
        var content = new ContentPage {
            Content = new Label {
                Text = "Hello, Form!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            }
        };

        MainPage = new NavigationPage (new StackLayoutExample());
    }
}
```
