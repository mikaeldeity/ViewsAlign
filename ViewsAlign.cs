using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsAlign
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    class Start : IExternalCommand
    {
        int counter = 0;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            Dictionary<string, Viewport> viewsdict = GetViewports(doc);

            if(viewsdict == null)
            {
                TaskDialog.Show("Error", "The current model does not contain any views on sheets.");
                return Result.Failed;
            }

            var aligndialog = new Dialogs.AlignDialog();

            List<string> views = viewsdict.Keys.ToList();

            views.Sort();

            aligndialog.ViewsListBox.DataSource = views;

            aligndialog.MasterViewDropDown.DataSource = views.ToArray();

            var dialog = aligndialog.ShowDialog();

            if (dialog != DialogResult.OK)
            {
                return Result.Cancelled;
            }

            Viewport masterview = viewsdict[aligndialog.MasterViewDropDown.SelectedItem.ToString()];

            List<Viewport> viewstoalign = new List<Viewport>();

            foreach (string name in aligndialog.ViewsListBox.SelectedItems.Cast<string>().ToList())
            {
                viewstoalign.Add(viewsdict[name]);
            }

            Transaction t1 = new Transaction(doc, "Align Views");

            t1.Start();

            AlignViewsToView(masterview, viewstoalign, aligndialog.AlignmentPointDropDown.SelectedItem.ToString());

            t1.Commit();

            if (counter > 0)
            {
                TaskDialog.Show("Complete", "Aligned " + counter + " views");
                return Result.Succeeded;
            }
            else
            {
                TaskDialog.Show("Error", "No views were aligned.");
                return Result.Failed;
            }            
        }
        internal void AlignViewsToView(Viewport mview, List<Viewport> views, string aligntype)
        {
            counter = 0;

            XYZ primaryCenter = mview.GetBoxCenter();
            Outline primaryOutline = mview.GetBoxOutline();

            foreach (Viewport v in views)
            {
                if(v.Id == mview.Id) { continue; }

                try
                {
                    XYZ newCenter = primaryCenter;

                    v.SetBoxCenter(primaryCenter);

                    XYZ delta;

                    Outline vOutline = v.GetBoxOutline();

                    if (aligntype == "Center")
                    {
                        newCenter = primaryCenter;

                    }
                    else if (aligntype == "Top Left")
                    {
                        XYZ d1 = new XYZ(primaryOutline.MinimumPoint.X, primaryOutline.MaximumPoint.Y, primaryOutline.MaximumPoint.Z);
                        XYZ d2 = new XYZ(vOutline.MinimumPoint.X, vOutline.MaximumPoint.Y, vOutline.MaximumPoint.Z);

                        delta = d2.Subtract(d1);

                        newCenter = v.GetBoxCenter().Subtract(delta);
                    }
                    else if (aligntype == "Top Right")
                    {
                        XYZ d1 = primaryOutline.MaximumPoint;

                        XYZ d2 = vOutline.MaximumPoint;

                        delta = d1.Subtract(d2);

                        newCenter = v.GetBoxCenter().Subtract(delta);
                    }
                    else if (aligntype == "Bottom Left")
                    {
                        XYZ d1 = primaryOutline.MinimumPoint;

                        XYZ d2 = vOutline.MinimumPoint;

                        delta = d2.Subtract(d1);

                        newCenter = v.GetBoxCenter().Subtract(delta);
                    }
                    else if (aligntype == "Bottom Right")
                    {
                        XYZ d1 = new XYZ(primaryOutline.MaximumPoint.X, primaryOutline.MinimumPoint.Y, primaryOutline.MaximumPoint.Z);

                        XYZ d2 = new XYZ(vOutline.MaximumPoint.X, vOutline.MinimumPoint.Y, vOutline.MaximumPoint.Z);

                        delta = d1.Subtract(d2);

                        newCenter = v.GetBoxCenter().Subtract(delta);
                    }

                    v.SetBoxCenter(newCenter);

                    counter++;
                }
                catch { }                
            }
        }
        internal Dictionary<string, Viewport> GetViewports(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Viewports);

            if(collector.Count() == 0)
            {
                return null;
            }

            Dictionary<string, Viewport> viewsdict = new Dictionary<string, Viewport>();

            foreach (Viewport v in collector)
            {
                ViewSheet s = doc.GetElement(v.OwnerViewId) as ViewSheet;

                Autodesk.Revit.DB.View vi = doc.GetElement(v.ViewId) as Autodesk.Revit.DB.View;

                string name = s.SheetNumber.ToString() + " - " + vi.ViewType.ToString() + " : " + vi.Name;

                if (!viewsdict.ContainsKey(name))
                {
                    viewsdict.Add(name, v);
                }
            }

            return viewsdict;
        }        
    }
}
