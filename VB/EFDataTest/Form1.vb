Imports DevExpress.DataAccess.UI.Wizard.Services
Imports DevExpress.Snap.Core.Services
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace EFDataTest
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            ' Prompt for loading a data assembly; default is NeverLoad.
            Me.snapControl1.Options.DataSourceLoadingOptions.EFCustomAssemblyBehavior = DevExpress.DataAccess.EntityFramework.CustomAssemblyBehavior.Prompt
			''Uncomment the string below to disable browsing for a custom assembly in the Data Source Wizard.
            'this.snapControl1.Options.DataSourceWizardOptions.EFWizardSettings.CustomAssemblyBehavior = DevExpress.DataAccess.EntityFramework.CustomAssemblyBehavior.NeverLoad;
            ' Handle this event to decide whether to load a custom data assembly.
            AddHandler Me.snapControl1.CustomAssemblyLoading, AddressOf SnapControl1_CustomAssemblyLoading
            ' The service is employed in the Data Source Wizard.
            Me.snapControl1.ReplaceService(Of ICustomAssemblyPathNotifier)(New myCustomAssemblyPathNotifier())
            ' The service is employed when loading a template.
            Me.snapControl1.ReplaceService(Of ICustomAssemblyLoadingNotificationService)(New myCustomAssemblyLoadingNotificationService())
        End Sub

        Private Sub SnapControl1_CustomAssemblyLoading(ByVal sender As Object, ByVal e As DevExpress.DataAccess.CustomAssemblyLoadingEventArgs)
            ' Decide whether to load a custom assembly.
            e.Cancel = MessageBox.Show(String.Format("Do you want to load data from {0}?", e.Path), "Security Warning", MessageBoxButtons.YesNo) = DialogResult.No
            ' Decide whether to query the service for the final decision.
            e.Handled = MessageBox.Show(String.Format("Is this your final decision?", e.Path), "Security Warning", MessageBoxButtons.YesNo) = DialogResult.Yes

        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create test.snx template and save it.
            MyHelper.CreateAndSaveReportTemplate(Me.snapControl1)
            Me.snapControl1.CreateNewDocument()
        End Sub

        Private Sub btnLoadTemplateWithData_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadTemplateWithData.ItemClick
            If System.IO.File.Exists("test.snx") Then
                Me.snapControl1.LoadDocument("test.snx")
                Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "Contacts"
            End If
        End Sub
    End Class

    Public Class myCustomAssemblyLoadingNotificationService
        Implements ICustomAssemblyLoadingNotificationService

        Public Function RequestApproval(ByVal assemblyPath As String) As Boolean Implements ICustomAssemblyLoadingNotificationService.RequestApproval
            Return MessageBox.Show(String.Format("Are you sure?" & ControlChars.Lf & "Loading {0}", assemblyPath), "Last Security Warning", MessageBoxButtons.OKCancel) = DialogResult.OK
        End Function
    End Class

    Public Class myCustomAssemblyPathNotifier
        Implements ICustomAssemblyPathNotifier

        Public Function RequestApproval(ByVal assemblyPath As String, ByVal owner As XtraForm) As Boolean Implements ICustomAssemblyPathNotifier.RequestApproval
            Return MessageBox.Show(String.Format("Are you sure?" & ControlChars.Lf & "Loading {0}", assemblyPath), "Last Security Warning", MessageBoxButtons.OKCancel) = DialogResult.OK
        End Function
    End Class
End Namespace
