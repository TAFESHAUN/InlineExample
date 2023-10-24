using InlineExample.ViewModel;
using InlineExample.Model_Data;

namespace InlineExample.View;

public partial class StudentProfile : ContentPage
{
	public StudentProfile()
	{
		InitializeComponent();
	}

    //Submit the data
    private async void Button_Clicked(object sender, EventArgs e)
    {
        //FORM LOGIC SUBMIT HERE
        string sendName = getName.Text.Trim();
        Student sendStu = new Student();
        await Navigation.PushAsync(new AboutUs(sendName, sendStu));
    }

    //SIMPLE EVENTS
    //StudentProfileViewModel -> SEARCH ASYNC FUNC -> SAFE and seperate way
    //Return student in question 

    //StudentProfileViewModel -> UpadateStudent(Found Student)

}