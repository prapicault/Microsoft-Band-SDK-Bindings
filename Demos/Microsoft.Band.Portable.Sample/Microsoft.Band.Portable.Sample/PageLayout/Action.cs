using Microsoft.Band;
using Microsoft.Band.Portable;
using Microsoft.Band.Portable.Tiles;
using Microsoft.Band.Portable.Tiles.Pages;
using Microsoft.Band.Portable.Tiles.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContextereApp.BandLayouts
{
	public class ActionScreen
	{
        public static ActionScreen screen = new ActionScreen();

		private readonly PageLayout pageLayout;
		private readonly PageData pageLayoutData;
		
		private readonly FilledPanel panel = new FilledPanel();
		private readonly TextButton button = new TextButton();
		private readonly WrappedTextBlock wrappedTextBlock = new WrappedTextBlock();
		private readonly TextBlock textBlock = new TextBlock();
		private readonly TextBlock textBlock2 = new TextBlock();

        internal TextButtonData buttonData = new TextButtonData
        {
            ElementId = 5,
            Text = "Yes"
        };
        internal WrappedTextBlockData wrappedTextBlockData = new WrappedTextBlockData
        {
            ElementId = 4,
            Text = "Connect sub-panel to main panel\r\n1. Attach sub"
        };
        internal TextBlockData textBlockData = new TextBlockData { ElementId = 3, Text = "DO" };
        internal TextBlockData textBlock2Data = new TextBlockData { ElementId = 2, Text = "contextere" };
		
		public ActionScreen()
		{
			//LoadIconMethod = LoadIcon;
			//AdjustUriMethod = (uri) => uri;
			
			panel = new FilledPanel();
			panel.BackgroundColorSource = ElementColorSource.Custom;
			panel.BackgroundColor = new BandColor(0, 0, 0);
			panel.Rect = new PageRect(0, 0, 258, 128);
			panel.ElementId = 1;
			panel.Margins = new Margins(0, 0, 0, 0);
			panel.HorizontalAlignment = HorizontalAlignment.Left;
			panel.VerticalAlignment = VerticalAlignment.Top;
			
			button = new TextButton();
			button.PressedColor = new BandColor(32, 32, 32);
			button.Rect = new PageRect(160, 32, 90, 32);
			button.ElementId = 5;
			button.Margins = new Margins(0, 0, 0, 0);
			button.HorizontalAlignment = HorizontalAlignment.Center;
			button.VerticalAlignment = VerticalAlignment.Top;
			
			panel.Elements.Add(button);
			
			wrappedTextBlock = new WrappedTextBlock();
			wrappedTextBlock.Font = WrappedTextBlockFont.Small;
			wrappedTextBlock.AutoHeight = false;
			wrappedTextBlock.ColorSource = ElementColorSource.Custom;
			wrappedTextBlock.Color = new BandColor(255, 255, 255);
			wrappedTextBlock.Rect = new PageRect(8, 61, 260, 200);
			wrappedTextBlock.ElementId = 4;
			wrappedTextBlock.Margins = new Margins(0, 0, 0, 0);
			wrappedTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
			wrappedTextBlock.VerticalAlignment = VerticalAlignment.Top;
			
			panel.Elements.Add(wrappedTextBlock);
			
			textBlock = new TextBlock();
			textBlock.Font = TextBlockFont.Small;
			textBlock.Baseline = 0;
			textBlock.BaselineAlignment = TextBlockBaselineAlignment.Automatic;
			textBlock.AutoWidth = true;
			textBlock.ColorSource = ElementColorSource.Custom;
			textBlock.Color = new BandColor(255, 255, 255);
			textBlock.Rect = new PageRect(7, 27, 32, 32);
			textBlock.ElementId = 3;
			textBlock.Margins = new Margins(0, 0, 0, 0);
			textBlock.HorizontalAlignment = HorizontalAlignment.Left;
			textBlock.VerticalAlignment = VerticalAlignment.Top;
			
			panel.Elements.Add(textBlock);
			
			textBlock2 = new TextBlock();
			textBlock2.Font = TextBlockFont.Small;
			textBlock2.Baseline = 0;
			textBlock2.BaselineAlignment = TextBlockBaselineAlignment.Automatic;
			textBlock2.AutoWidth = true;
			textBlock2.ColorSource = ElementColorSource.Custom;
			textBlock2.Color = new BandColor(64, 199, 243);
			textBlock2.Rect = new PageRect(7, -1, 32, 32);
			textBlock2.ElementId = 2;
			textBlock2.Margins = new Margins(0, 0, 0, 0);
			textBlock2.HorizontalAlignment = HorizontalAlignment.Left;
			textBlock2.VerticalAlignment = VerticalAlignment.Top;
			
			panel.Elements.Add(textBlock2);
			pageLayout = new PageLayout(panel);

            pageLayoutData = new PageData()
            {
                PageId = Guid.NewGuid(),
                PageLayoutIndex = 3,
                Data = { buttonData, wrappedTextBlockData, textBlockData, textBlock2Data }
            };
		}
		
		public PageLayout Layout
		{
			get
			{
				return pageLayout;
			}
		}

        public PageData Data
        {
            get
            {
                return pageLayoutData;
            }
        }
		
		//public PageLayoutData Data
		//{
		//	get
		//	{
		//		return pageLayoutData;
		//	}
		//}
		
		//public Func<string, Task<BandIcon>> LoadIconMethod
		//{
		//	get;
		//	set;
		//}
		
		public Func<string, string> AdjustUriMethod
		{
			get;
			set;
		}
		
		//private static async Task<BandIcon> LoadIcon(string uri)
		//{
		//	StorageFile imageFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri(uri));
			
		//	using (IRandomAccessStream fileStream = await imageFile.OpenAsync(FileAccessMode.Read))
		//	{
		//		WriteableBitmap bitmap = new WriteableBitmap(1, 1);
		//		await bitmap.SetSourceAsync(fileStream);
		//		return bitmap.ToBandIcon();
		//	}
		//}
		
		public async Task LoadIconsAsync(BandTile tile)
		{
			await Task.Run(() => { }); // Dealing with CS1998
		}
		
		public static BandTheme GetBandTheme()
		{
			var theme = new BandTheme();
			theme.Base = new BandColor(51, 102, 204);
			theme.HighContrast = new BandColor(58, 120, 221);
			theme.Highlight = new BandColor(58, 120, 221);
			theme.Lowlight = new BandColor(49, 101, 186);
			theme.Muted = new BandColor(43, 90, 165);
			theme.SecondaryText = new BandColor(137, 151, 171);
			return theme;
		}
		
		public static BandTheme GetTileTheme()
		{
			var theme = new BandTheme();
			theme.Base = new BandColor(51, 102, 204);
			theme.HighContrast = new BandColor(58, 120, 221);
			theme.Highlight = new BandColor(58, 120, 221);
			theme.Lowlight = new BandColor(49, 101, 186);
			theme.Muted = new BandColor(43, 90, 165);
			theme.SecondaryText = new BandColor(137, 151, 171);
			return theme;
		}
	}
}
