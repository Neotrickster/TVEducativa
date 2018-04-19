using System;
using TVEducativa.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TVEducativa.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TVEducativaCanales : ContentPage
	{
	    //public string screenSizeHeight {get; set;}

	    public TVEducativaCanales ()
		{
		    InitializeComponent();
            BindingContext = new TVEducativaCanalesViewModel();
            //var device = Resolver.Resolve();
            //var displayHeight = device.Display.Height;
            //var displayWidth = device.Display.Width;
            Canal.FontSize = Canal.FontSize + 5;
		    //var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
		    //Canal.Text = Canal.Text + "(" + size.Width + ")" + "(" + size.Height + ")" + "(" + ((size.Height - 270) / 4) + ")";
            //screenSizeHeight = ((size.Height - 270) / 4).ToString();
		    //screenSizeHeight = "103";
            //this.BindingContext = new TVEducativaCanales();
            //BindingContext = this;
            //VideoPlayer.FullScreenStatusChanged += VideoPlayer_FullScreenStatusChanged;
        }

        //private void VideoPlayer_FullScreenStatusChanged(object sender, bool value)
        //{
        //    NavigationPage.SetHasNavigationBar(this, !value);
        //}

        private double _width = 0;
        private double _height = 0;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
            if (this._width != width || this._height != height)
            {
                this._width = width;
                this._height = height;
                //reconfigurar layout cuando se gira el teléfono
                if (width > height)
                {
                    //outerStack.Orientation = StackOrientation.Horizontal;
                    //outterScroll.IsVisible = true;
                    innerStack.IsVisible = false;
                    //innerGrid.IsVisible = false;
                    //Canal.IsVisible = false;
                    //VideoPlayer.
                    //InvalidateMeasure();
                }
                else
                {
                    //outerStack.Orientation = StackOrientation.Vertical;
                    //outterScroll.IsVisible = false;
                    innerStack.IsVisible = true;
                    //innerGrid.IsVisible = true;
                    //Canal.IsVisible = true;
                    //Canal.Text = Canal.Text + "(" + this._width + ")" + "(" + this._height + ")";
                    //InvalidateMeasure();
                }
            }
        }

        private void PlayAprButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/ilcea/live.mp4?scheme=m3u8";
	        VideoPlayer.Play();
	        Canal.Text = "Aprende TV";
        }

	    private void PlayCapButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/canaliberoamericano1/live.mp4?scheme=m3u8";
	        VideoPlayer.Play();
	        Canal.Text = "Capacita TV";
        }

	    private void PlayIngButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/ilcea/live.mp4?scheme=m3u8";
	        VideoPlayer.Play();
	        Canal.Text = "Ingenio TV";
        }

	    private void PlayTBButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/canaliberoamericano1/live.mp4?scheme=m3u8";
	        VideoPlayer.Play();
	        Canal.Text = "Telebachillerato";
        }

	    private void PlayTSButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/ilcea/live.mp4?scheme=m3u8";
	        VideoPlayer.Play();
	        Canal.Text = "Telesecundaria";
        }

	    private void PlayTSMButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/canaliberoamericano1/live.mp4?scheme=m3u8";
	        VideoPlayer.Play();
	        Canal.Text = "Telesecundaria+";
        }
	}
}