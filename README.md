### สร้าง Solution

- `Multiplatform` -> `Xamarin.Forms` -> `Forms App (C#/F#)`

###  เขียน `ContentPage` ด้วย CSharp

- ไฟล์ `StackLayoutExample.cs`

```csharp
public class StackLayoutExample : ContentPage {
    public StackLayoutExample () {
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

- ไฟล์ `Intro.cs`

```csharp
public class App : Application {
    public App () {
        MainPage = new NavigationPage (new StackLayoutExample());
    }
}
```

### Link

- https://developer.xamarin.com/guides/xamarin-forms/getting-started/introduction-to-xamarin-forms
