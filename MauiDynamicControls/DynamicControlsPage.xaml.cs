namespace MauiDynamicControls;

public partial class DynamicControlsPage : ContentPage
{
    int countup = 0;
    int countdown = 0;
    public DynamicControlsPage()
	{
		InitializeComponent();
        //הוספת הפקדים בצורה דינאמית
		InitializeControlls();
	}

    private void InitializeControlls()
    {
		//Add your Code Here
      
		AddLayout();  //הוסף פריסה
        
        AddLabels();//הוסף את תווית
       
        AddButtons(); //הוסף כפתורים



    }

    private void AddLayout()
    {
        //יצירת פריסה חדשה

        //לאורך או לרוחב

        //רווח

        //המרחק בין הפקדים בתוך הפריסה

        //מיקום ביחס למסך

        //הצבת הפקד בתוך המסך

      
    }
    private void AddLabels()
    {
        //יצירת הפקד
        //{
        
        //}
    
       
        //OnPlatform....=>DeviceInfo.Current.Platform=DevicePlatform....
      
       //הוספת הפקד למסך
       //הערה: ניתן להגדיר שהפעולה הנוכחית מחזירה את הפקד החדש שנוצר 
       //ונגדיר פעולה נוספת המקבלת רשימת פקדים ומוסיפה אותם לפריסה
       
     
       
    }

    //כפתורים
    private void AddButtons()
    {
        //נאתר את הפריסה

        //ניצור כפתור 1==="\uef7d"

        //הוספת איקון לכפתור

        //הרשמה לאירוע


        //כפתור 2
        //"\ue941"

        //הרשמה לאירוע באמצעות anoymous functions =>


        //התאמת גדלי אייקון - 20 ו-30
    }

    private void ClickedUpEvent(object sender, EventArgs e)
    {
        countup++;
        StackLayout stk= (StackLayout)this.Content;
        Label lbl_txt = stk.Children.FirstOrDefault(x=>x is Label) as Label;
        lbl_txt.Text = $"  פעמים {countup} לחצתי למעלה";
    }
}