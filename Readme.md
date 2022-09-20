<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608758/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T408545)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/EFDataTest/Form1.cs) (VB: [Form1.vb](./VB/EFDataTest/Form1.vb))
<!-- default file list end -->
# How to prevent loading untrusted custom assembly in EF data model

> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

This example addresses securirty considerations that are specific to creating reports or loading report templates which are bound to Entity Framework data models contained in a compiled assembly. Before loading the data assembly you should have an option to perform a path check to ensure that an assembly is obtained from a trusted source and that the path length is within valid limits.

### Description

Handle the [DevExpressDataAccessEntityFrameworkEFDataSource.BeforeLoadCustomAssembly](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.EntityFramework.EFDataSource.BeforeLoadCustomAssembly) event to allow loading a custom assembly; if you do not handle this event, an attempt to load a custom assembly by the Entity Framework data source will throw the [CustomAssemblyLoadingProhibitedException](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.EntityFramework.CustomAssemblyLoadingProhibitedException).   

When a report template is loading, the SnapControl creates a data source from the string serilalized in the .snx file. An attempt to load the Entity Framework data model fires the [SnapControl.BeforeLoadCustomAssembly](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.SnapControl.BeforeLoadCustomAssembly?v=21.2) event. If the [e.AllowLoading](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.EntityFramework.BeforeLoadCustomAssemblyEventArgs.AllowLoading)  property is set to **true**, the assembly is loaded.   

To demonstrate the behavior described above, run this example. On the first run it creates a complied assembly containing Entity Framework data model; subsequently it creates the template which contains a data source bound to the assembly.  To load the data-bound template, click the **Load Template with Data** button. The BeforeLoadCustomAssembly event handler prompts you for the `e.AllowLoading` value.  

You can show the Browse button (hidden by default)  in the Data Access Wizard by toggling the **Browse for Assembly** switch in the Data Wizard Options group. Click **Add New Data Source**, select **Entity Framework** and browse for the _EFDataModel.dll_ assembly located at the application executable path. When you click **Open** to load this assembly, provide the Wizard with the following connection string:

`Data Source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Contacts.mdf;integrated security=True;`
