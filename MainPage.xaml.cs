namespace webview_bug_macOS;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        
        MyWebView.Source = "https://www.w3schools.com/howto/tryit.asp?filename=tryhow_html_file_upload_button";

    }

   
}