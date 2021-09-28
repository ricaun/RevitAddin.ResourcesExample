using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace RevitAddin.ResourcesExample.Extensions
{
    public static class BitmapExtension
    {
        public static BitmapSource GetBitmapSource(this System.Drawing.Bitmap bitmap)
        {
            var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return bitmapSource;
        }

        public static BitmapSource GetBitmapSource(this System.Drawing.Icon icon)
        {
            var bitmapSource = Imaging.CreateBitmapSourceFromHIcon(
                icon.ToBitmap().GetHicon(),
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return bitmapSource;
        }
    }
}