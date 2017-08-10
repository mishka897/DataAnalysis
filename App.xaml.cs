using Xamarin.Forms;

namespace DataAnalysis
{
    public partial class App : Application
    {
        public App()
        {
			InitializeComponent();

            // Starting page 
            MainPage = new DataAnalysisPage();

/*

            MainPage = new ContentPage()
            {
                //lbl and btn empty 

                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,Children = 
                    {
                    btn1
                    }
                 }
             };	


            //btn clicked -> reader reads xml file and displays content on lbl1
             btn1.Clicked += (sender, e) =>
                        {
                            btn1.Text = "You clicked me!!";
                           // lbl1.Text = DataTemplates.reader.GetAttribute("Lieferdienst");
                        };

            // Second page displaying new content triggered by btn1
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        lbl1, btn1 
                    }
                }
            };
 */           

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
