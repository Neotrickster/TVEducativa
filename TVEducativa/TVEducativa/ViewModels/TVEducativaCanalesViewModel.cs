using System;
using System.Collections.Generic;
using System.Text;

namespace TVEducativa.ViewModels
{
    class TVEducativaCanalesViewModel : BaseViewModel
    {
        public int screenSizeHeight { get; set; }

        public TVEducativaCanalesViewModel()
        {
            Title = "Mi Televisión Educativa";

            var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
            screenSizeHeight = (int)((size.Height - 270) / 4);
        }

        
    }
}
