using RevitAddin.ResourcesExample.Extensions;
using System;
using System.Windows;

namespace RevitAddin.ResourcesExample.Views
{
    public partial class ResourcesView : Window
    {
        public ResourcesView()
        {
            InitializeComponent();
            InitializeWindow();

            Title = Properties.Views.Resource.Title;
            Icon = Properties.Views.Resource.Icon.GetBitmapSource();
            image.Source = Properties.Views.Resource.Image.GetBitmapSource();
        }

        #region InitializeWindow
        private void InitializeWindow()
        {
            this.SizeToContent = SizeToContent.WidthAndHeight;
            this.ShowInTaskbar = false;
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            new System.Windows.Interop.WindowInteropHelper(this) { Owner = Autodesk.Windows.ComponentManager.ApplicationWindow };
        }
        #endregion
    }
}