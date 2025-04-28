using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace ArchiHelloWorld
{
    /// <summary>
    /// A simple ExternalCommand for Revit that shows a Hello World message
    /// and links to your Revit plugins page.
    /// </summary>
    public class HelloWorldCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            // Show a Revit dialog
            TaskDialog td = new TaskDialog("Archi Revit Plugins");
            td.MainInstruction = "Hello from Archi!";
            td.MainContent = "Thanks for trying our Revit plugin demo.\n\n"
                           + "👉 Visit http://goto.archi/revit-plugins for all our free Revit add-ins.";
            td.AddCommandLink(TaskDialogCommandLinkId.CommandLink1, "Open in Browser");
            td.CommonButtons = TaskDialogCommonButtons.Close;

            TaskDialogResult res = td.Show();
            if (res == TaskDialogResult.CommandLink1)
            {
                // launch default browser
                System.Diagnostics.Process.Start(
                  new System.Diagnostics.ProcessStartInfo
                  {
                      FileName = "http://goto.archi/revit-plugins",
                      UseShellExecute = true
                  });
            }
            return Result.Succeeded;
        }
    }
}
