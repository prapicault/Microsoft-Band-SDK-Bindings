using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Microsoft.Band.Portable.Sample
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //ClientPage.band.NotificationManager.SendMessageAsync(ClientPage.tile.Id, "Hi", "My message", DateTime.Now, true);
            ClientPage.band.TileManager.TileButtonPressed += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(() => helloClicked(null, null));
               
            };

            ClientPage.band.TileManager.StartEventListenersAsync();
        }

        private async void helloClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        protected
    }
}
