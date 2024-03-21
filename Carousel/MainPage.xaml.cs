using Syncfusion.Maui.Carousel;

namespace Carousel {
    public partial class MainPage : ContentPage {
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
                var nameButton = new Button() { BackgroundColor = Colors.Transparent, TextColor = Colors.Blue };
                nameButton.SetBinding(Button.TextProperty, "ButtonString");
                var nameLabel = new Label() { TextColor = Colors.Red, HorizontalTextAlignment = TextAlignment.Center };
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

    }
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
}