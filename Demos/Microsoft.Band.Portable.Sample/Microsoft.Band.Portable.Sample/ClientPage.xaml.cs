using System;

using Microsoft.Band.Portable.Sample.ViewModels;
using System.Threading.Tasks;
using Microsoft.Band.Portable.Tiles;

namespace Microsoft.Band.Portable.Sample
{
    public partial class ClientPage : BaseContentPage
    {
        private ClientViewModel clientViewModel;
        public static BandClient band;
        public static BandTile tile;

        public ClientPage(BandDeviceInfo info)
        {
            InitializeComponent();

            clientViewModel = new ClientViewModel(info);

            ViewModel = clientViewModel;
        }

        private void SensorsButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SensorsPage(clientViewModel.BandInfo, clientViewModel.BandClient));
        }

        private void TilesButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TilesPage(clientViewModel.BandInfo, clientViewModel.BandClient));
		}

		private void VibrationsButtonClick(object sender, EventArgs e)
		{
			Navigation.PushAsync(new VibrationsPage(clientViewModel.BandInfo, clientViewModel.BandClient));
		}

        private void PersonalizationButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PersonalizationPage(clientViewModel.BandInfo, clientViewModel.BandClient));
        }

        private async void pascalButtonClick(object sender, EventArgs e)
        {
            await setupBand();
            await Navigation.PushAsync(new Page1());
        }

        private async Task setupBand()
        {
            band = clientViewModel.BandClient;
            var newTiles = (await band.TileManager.GetTilesAsync());
            foreach (var item in newTiles)
            {
                if (item.Name == "New Tile")
                {
                    tile = item;
                }
            }
            //Debug.WriteLine("loading tiles");
            //tile = newTiles.Where(n => newTiles.All(o => o.Name == "New Tile")).First();
            //Debug.WriteLine("found tile");
        }
    }
}
