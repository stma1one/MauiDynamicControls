using Microsoft.Maui.Controls.Platform;

namespace MauiDynamicControls;

public partial class MainPage : ContentPage
{
	int countup = 0;
	int countdown = 0;

	public MainPage()
	{
		InitializeComponent();
		
		

		
			
		
	}

    private void ODownClicked(object sender, EventArgs e)
    {
		countdown++;
		lbl_txt.Text = $"  פעמים {countdown} לחצתי למטה";
    }

    private void OnUpClicked(object sender, EventArgs e)
    {
		countup++;
		lbl_txt.Text = $"  פעמים {countup} לחצתי למעלה";

    }
}

