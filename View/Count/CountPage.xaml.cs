namespace firstproject.View.Count;

public partial class CountPage : ContentPage{
  int count = 0;
	public CountPage(){
		InitializeComponent();
	}
  
  private void countPlus(object sender, EventArgs e){
    count++;
    if(count == 1) countButton.Text = $"{count}";
    else countButton.Text = $"{count}";
    
  }
}