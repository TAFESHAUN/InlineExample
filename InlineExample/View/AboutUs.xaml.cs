using InlineExample.Model_Data;

namespace InlineExample.View;

public partial class AboutUs : ContentPage
{
	public string sentName;
	public AboutUs(string name, Student sentStudent) //10-30 entries in a form, Just the viewmodel
	{
		InitializeComponent();
		sentName = name;

		//SET OBJECT
		sentStudent.Id = 1;
		sentStudent.Name = name;

        //SET UI WITH OBJ DATA
		sentStuID.Text = sentStudent.Id.ToString();
        setSentName.Text = sentStudent.Name;

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert($"The Name is {sentName}",$"The name is {sentName}","OK");
    }
}