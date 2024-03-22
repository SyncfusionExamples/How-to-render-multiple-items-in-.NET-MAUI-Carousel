# How-to-render-multiple-items-in-.NET-MAUI-Carousel
This section explains how to render multiple items in .NET MAUI Carousel.

We achieve this by adding various controls to a parent layout and assigning it as the content of each carousel item.

**C#**

**Model**
```
class CarouselModel 
{
    public CarouselModel(string imagestr, string buttonstring, string labelstring)
    {
        Image = imagestr;
        ButtonString = buttonstring;
        LabelString = labelstring;
    }
    public string Image { get; set; }
    public string ButtonString { get; set; }
    public string LabelString { get; set; }  
 }
```
**C#**

```
 public MainPage() 
 {
     InitializeComponent();
     SfCarousel sfCarousel = new SfCarousel();     
     var carouselModel = new List<CarouselModel> 
     {
        new CarouselModel("image1.png","Button1","Label1" ),
        new CarouselModel ("image2.png","Button2","Label2"),
        new CarouselModel ("image3.png","Button3","Label3"),
        new CarouselModel ("image4.png","Button4","Label4"),
        new CarouselModel ("image5.png","Button5","Label5") 
     };
     var carouselModelDataTemplate = new DataTemplate(() =>
     {
         var stack = new StackLayout();
         var nameImage = new Image();
         nameImage.SetBinding(Image.SourceProperty, "Image");
         var nameButton = new Button() { BackgroundColor = Colors.Transparent,TextColor = Colors.Blue };
         nameButton.SetBinding(Button.TextProperty, "ButtonString");
         var nameLabel = new Label() { TextColor = Colors.Red,HorizontalTextAlignment = TextAlignment.Center };
         nameLabel.SetBinding(Label.TextProperty, "LabelString");
         stack.Children.Add(nameButton);
         stack.Children.Add(nameImage);
         stack.Children.Add(nameLabel);
         return stack;
     });
     sfCarousel.ItemTemplate = carouselModelDataTemplate;
     sfCarousel.ItemsSource = carouselModel;
     this.Content = sfCarousel;
 }
```
## How to run this application?

To run this application, you need to first clone the How-to-render-multiple-items-in-.NET-MAUI-Carousel repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
