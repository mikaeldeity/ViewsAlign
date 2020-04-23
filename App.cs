using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace ViewsAlign
{
    public class App : IExternalApplication
    {
        static void AddRibbonPanel(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Views");

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;            

            PushButtonData b1Data = new PushButtonData("Align Views", "Align Views", thisAssemblyPath, "ViewsAlign.Start");
            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Align views on sheets.";
            BitmapImage pb1Image = new BitmapImage(new Uri("pack://application:,,,/ViewsAlign;component/Resources/VA.png"));
            pb1.LargeImage = pb1Image;            
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            AddRibbonPanel(application);
            return Result.Succeeded;
        }
    }    
}
