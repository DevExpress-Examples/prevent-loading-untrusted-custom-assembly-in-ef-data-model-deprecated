<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608758/16.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T408545)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/EFDataTest/Form1.cs) (VB: [Form1.vb](./VB/EFDataTest/Form1.vb))
<!-- default file list end -->
# How to prevent loading untrusted custom assembly in EF data model


This example addresses securirty considerations that are specific to creating reports or loading report templates which are bound to Entity Framework data models contained in a compiled assembly.<br>Before loading the data assembly you should have an option to perform a path check to ensure that an assembly is obtained from a trusted source and that the path length is within valid limits.


<h3>Description</h3>

When a report template is loading, the SnapControl creates a data source from the string serilalized in the .snx file. The <strong>SnapControl.Options.DataSourceLoadingOptions.EFCustomAssemblyBehavior</strong> option allows you to specify whether to load custom data assemblies, not load them or perform additional steps to decide for each file. An attempt to load the Entity Framework data model fires the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapSnapControl_CustomAssemblyLoadingtopic">SnapControl.CustomAssemblyLoading</a>&nbsp;event (if this event has a subscriber). If there is no subscription or the <strong>e.Handled</strong>&nbsp;property is set to <strong>false</strong>, the <strong>RequestApproval</strong>&nbsp;method of the SnapControl service which implements the&nbsp;<a href="http://help.devexpress.com/#WindowsForms/clsDevExpressSnapCoreServicesICustomAssemblyLoadingNotificationServicetopic">ICustomAssemblyLoadingNotificationService</a>&nbsp;interface is&nbsp;called. If it returns <strong>true,</strong> the assembly is loaded.<br>&nbsp;<br>When the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument15603">Data Source Wizard</a> is used to bind to the&nbsp;Entity Framework data model, the <strong>SnapControl.Options.DataSourceWizardOptions.EFWizardSettings.CustomAssemblyBehavior&nbsp;</strong>setting determines whether the Wizard allows loading a custom assembly. &nbsp;If the setting has the&nbsp;<strong>DevExpress.DataAccess.EntityFramework.CustomAssemblyBehavior.Prompt</strong> value (default), the&nbsp;<strong>RequestApproval</strong>&nbsp;method of the SnapControl service which implements the&nbsp;<a href="http://help.devexpress.com/#WindowsForms/clsDevExpressDataAccessUIWizardServicesICustomAssemblyPathNotifiertopic">ICustomAssemblyPathNotifier</a>&nbsp;interface is&nbsp;called. If it returns <strong>true,</strong> the assembly is loaded.<br><br>To demonstrate the behavior described above, run this example. On the first run it creates a complied assembly containing Entity Framework data model; subsequently it creates the template which contains&nbsp;a data source bound to the assembly. &nbsp;To load the data-bound template, click the<strong> Load Template with Data</strong> button. The&nbsp;CustomAssemblyLoading&nbsp;event handler prompts you for the e.Cancel and e.Handler values. If your answer sets the e.Handler value to&nbsp;<strong>false,</strong>&nbsp;the decision falls back to the custom service which displays a dialog&nbsp;for the final answer.<br>After loading a report template, explore the Data Source Wizard behavior. Click <strong>Add New Data Source</strong>, select <strong>Entity Framework</strong> and&nbsp;browse for the&nbsp;<em>EFDataModel.dll</em> assembly located at the application executable path. When you click <strong>Open</strong> to load this assembly, the service prompts you for the final decision. If you click OK, provide the Wizard with the following connection string:<br>
<code lang="cs">Data Source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Contacts.mdf;integrated security=True;</code>

<br/>


