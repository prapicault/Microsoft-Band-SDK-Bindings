using System;
using System.Collections.Generic;
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
            ClientPage.band.NotificationManager.SendMessageAsync(ClientPage.tile.Id, "Hi", "My message", DateTime.Now, true);
            //ClientPage.band.TileManager.TileButtonPressed += (sender, e) =>
            //{

            //    Debug.WriteLine("here we should go to the next page");
            //};

            //ClientPage.band.TileManager.StartEventListenersAsync();
        }

        private void helloClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
