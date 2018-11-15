<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/EFDataTest/Form1.cs) (VB: [Form1.vb](./VB/EFDataTest/Form1.vb))
<!-- default file list end -->
# How to prevent loading untrusted custom assembly in EF data model


This example addresses securirty considerations that are specific to creating reports or loading report templates which are bound to Entity Framework data models contained in a compiled assembly.<br>Before loading the data assembly you should have an option to perform a path check to ensure that an assembly is obtained from a trusted source and that the path length is within valid limits.


<h3>Description</h3>

Handle the&nbsp;<a href="http://help.devexpress.com/#CoreLibraries/DevExpressDataAccessEntityFrameworkEFDataSource_BeforeLoadCustomAssemblytopic">DevExpressDataAccessEntityFrameworkEFDataSource.BeforeLoadCustomAssembly</a>&nbsp;event to allow loading a custom assembly; if you do not handle this event,&nbsp;an attempt to load a custom assembly by the Entity Framework data source will throw the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressDataAccessEntityFrameworkCustomAssemblyLoadingProhibitedExceptiontopic">CustomAssemblyLoadingProhibitedException</a>.&nbsp;<br>When a report template is loading, the SnapControl creates a data source from the string serilalized in the .snx file. An attempt to load the Entity Framework data model fires the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapSnapControl_BeforeLoadCustomAssemblytopic">SnapControl.BeforeLoadCustomAssembly</a>&nbsp;event. If the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressDataAccessEntityFrameworkBeforeLoadCustomAssemblyEventArgs_AllowLoadingtopic">DevExpress.DataAccess.EntityFramework.BeforeLoadCustomAssemblyEventArgs.AllowLoading</a>&nbsp; property is set to&nbsp;<strong>true,</strong> the assembly is loaded.&nbsp;<br>To demonstrate the behavior described above, run this example. On the first run it creates a complied assembly containing Entity Framework data model; subsequently it creates the template which contains&nbsp;a data source bound to the assembly. &nbsp;To load the data-bound template, click the<strong> Load Template with Data</strong> button. The BeforeLoadCustomAssembly event handler prompts you for the e.AllowLoading value.<br>You can show the Browse button (hidden by default) &nbsp;in the Data Access Wizard by toggling&nbsp;the&nbsp;<strong>Browse for Assembly</strong> switch in the Data Wizard Options group. Click <strong>Add New Data Source</strong>, select <strong>Entity Framework</strong> and&nbsp;browse for the&nbsp;<em>EFDataModel.dll</em> assembly located at the application executable path. When you click <strong>Open</strong> to load this assembly, provide the Wizard with the following connection string:<br>
<code lang="cs">Data Source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Contacts.mdf;integrated security=True;</code>

<br/>


