#### สร้าง Solution

- `New` -> `Solution` -> `Multiplatform` -> `Xamarin.Forms` -> `Forms App (C#)` -> `Intro`

####  เขียน `ContentPage` ด้วย `C#`

- `New` -> `File` -> `Empty class` -> `StackLayoutExample.cs`

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

#### สามารถปรับ Layout ใน `StackLayout` ดังนี้

```csharp
Content = new StackLayout {
    Spacing = 10,
    VerticalOptions = LayoutOptions.End,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StackOrientation.Horizontal,
    Children = { red, yellow, green }
};
```

#### Link

- https://developer.xamarin.com/guides/xamarin-forms/getting-started/introduction-to-xamarin-forms
