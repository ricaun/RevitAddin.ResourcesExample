using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitAddin.ResourcesExample.Revit
{
    public class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}