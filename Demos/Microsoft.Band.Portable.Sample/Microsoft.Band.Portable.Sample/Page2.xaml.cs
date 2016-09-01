using ContextereApp.BandLayouts;
using Microsoft.Band.Portable.Tiles.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Microsoft.Band.Portable.Sample
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ActionScreen.screen.wrappedTextBlockData.Text = "This is the end";
            ActionScreen.screen.buttonData.Text = "DONE";
            ClientPage.band.TileManager.SetTilePageDataAsync(ClientPage.tile.Id, new PageData[] { ActionScreen.screen.Data });
        }
    }
}
