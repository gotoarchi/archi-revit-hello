# archi-revit-hello

# Archi Revit Hello-World Plugin

**Just for fun** — a tiny Autodesk Revit add-in that pops up a “Hello from Archi!” message with a link to our full suite of free plugins.

## How to Install

1. Build the `HelloWorldCommand` project in Visual Studio (target .NET Framework 4.8).  
2. Copy the resulting `HelloWorldCommand.dll` to your Revit Addins folder, e.g.:

%APPDATA%\Autodesk\REVIT\Addins\2025\

3. Also copy the `HelloWorld.addin` manifest there.  
4. Launch Revit 2025 → Look under **Add-Ins** → click **ArchiHelloWorld**.

## What You’ll See

A dialog titled **“Archi Revit Plugins”** that says:

> Hello from Archi!  
> Thanks for trying our Revit plugin demo.  
> 👉 Visit http://goto.archi/revit-plugins for all our free Revit add-ins.
