using ContextereApp.BandLayouts;
using Microsoft.Band.Portable.Tiles.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using static Microsoft.Band.Portable.Sample.ViewModels.AddTileViewModel;

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

            PageData pd = new PageData
            {
                PageId = TilePages.ImagePage.Id,
                PageLayoutIndex = 1,
                Data = {
                        new TextBlockData {
                            ElementId = TilePages.ImagePage.TextBlockTitleId,
                            Text = "Page Images"
                        },
                        new ImageData {
                            ElementId = TilePages.ImagePage.ImageId1,
                            ImageIndex = 0
                        },
                        new ImageData {
                            ElementId = TilePages.ImagePage.ImageId2,
                            ImageIndex = 2
                        }
                    }
            };
            ClientPage.band.TileManager.RemoveTilePagesAsync(ClientPage.tile.Id);
            ClientPage.band.TileManager.SetTilePageDataAsync(ClientPage.tile.Id, new PageData[] { pd });
        }
    }
}
