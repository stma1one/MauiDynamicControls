namespace MauiDynamicControls;

public partial class DynamicControlsPage : ContentPage
{
    int countup = 0;
    int countdown = 0;
    public DynamicControlsPage()
	{
		InitializeComponent();
		InitializeControlls();
	}

    private void InitializeControlls()
    {
		//Add your Code Here

		AddLayout();
        AddLabels();
        AddButtons();



    }

    private void AddLayout()
    {
        StackLayout stackLayout = new StackLayout();
        stackLayout.Orientation = StackOrientation.Vertical;
        stackLayout.Padding = new Thickness(30, 0);
        stackLayout.Spacing = 35;
        stackLayout.VerticalOptions = LayoutOptions.Center;
        this.Content = stackLayout;
    }
    private void AddLabels()
    {
        Label label = new Label()
        {

            HorizontalOptions = LayoutOptions.Center,
            Text = "פה יופיע כמה פעמים לחצו על כל כפתור",
            TextColor = Color.FromArgb("#7b32a8")



        };
       if(DeviceInfo.Current.Platform== DevicePlatform.Android || DeviceInfo.Current.Platform==DevicePlatform.iOS)
         {
            label.FontSize = 12;  
        }
       else
            label.FontSize = 24;

       StackLayout stk= (StackLayout)this.Content;
        stk.Children.Add(label);
       
    }
   
    private void AddButtons()
    {
        StackLayout stk = (StackLayout)this.Content;
        Button btnUp = new Button()
        {
            Text = "למעלה",
            TextColor = Colors.Black,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 100,
            HeightRequest = 100,
            BorderWidth = 1,
            CornerRadius = 50,
            BackgroundColor=Colors.Yellow,
            ImageSource = new FontImageSource()
            {
                Color = Colors.Red,
                Glyph = "\uef7d",
                FontFamily = "MaterialSymbolsSharp",
                
                Size=12,
                

            }                
        };
        btnUp.Clicked += ClickedUpEvent;


        Button btnDown = new Button()
        {
            Text = "למטה",
            TextColor= Colors.Black,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 100,
            HeightRequest = 100,
            BorderWidth = 1,
            CornerRadius = 50,
            BackgroundColor = Colors.Yellow,
            ImageSource = new FontImageSource()
            {
                Color = Colors.Brown,
                Glyph = "\ue941",
                FontFamily = "MaterialSymbolsSharp",
                Size = 12,


            }
        };
        btnDown.Clicked += (s, e) =>
        {
            countdown++;
           
            Label lbl_txt = stk.Children.Where( x => x is Label).FirstOrDefault() as Label;
            lbl_txt.Text = $"  פעמים {countdown} לחצתי למטה";
        };

        if (DeviceInfo.Current.Platform == DevicePlatform.Android || DeviceInfo.Current.Platform == DevicePlatform.iOS)
        {
           ((FontImageSource) btnDown.ImageSource).Size = 20;
            ((FontImageSource)btnUp.ImageSource).Size = 20;
        }
        else
        {
            ((FontImageSource)btnDown.ImageSource).Size = 30;
            ((FontImageSource)btnUp.ImageSource).Size = 30;
        }

        stk.Children.Insert(0, btnUp);
        stk.Children.Insert(stk.Children.Count, btnDown);
        

    }

    private void ClickedUpEvent(object sender, EventArgs e)
    {
        countup++;
        StackLayout stk= (StackLayout)this.Content;
        Label lbl_txt = stk.Children.FirstOrDefault(x=>x is Label) as Label;
        lbl_txt.Text = $"  פעמים {countup} לחצתי למעלה";
    }
}