Imports System
Imports System.Windows.Forms

Namespace EFDataTest

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            ' Handle this event to decide whether this application allows loading a custom data assembly.
            AddHandler DevExpress.DataAccess.EntityFramework.EFDataSource.BeforeLoadCustomAssemblyGlobal, AddressOf EFDataSource_BeforeLoadCustomAssemblyGlobal
            ' Handle this event to allow loading a custom data assembly when the SnapControl queries the data source.
            AddHandler snapControl1.BeforeLoadCustomAssembly, AddressOf SnapControl1_BeforeLoadCustomAssembly
        End Sub

        Private Sub EFDataSource_BeforeLoadCustomAssemblyGlobal(ByVal sender As Object, ByVal args As DevExpress.DataAccess.EntityFramework.BeforeLoadCustomAssemblyEventArgs)
            args.AllowLoading = True
        End Sub

        Private Sub SnapControl1_BeforeLoadCustomAssembly(ByVal sender As Object, ByVal args As DevExpress.DataAccess.EntityFramework.BeforeLoadCustomAssemblyEventArgs)
            ' Decide whether to load a custom assembly.
            args.AllowLoading = MessageBox.Show(String.Format("Do you want to load data from {0}?", args.AssemblyPath), "Snap Security Warning", MessageBoxButtons.YesNo) = DialogResult.Yes
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create test.snx template and save it.
            CreateAndSaveReportTemplate(snapControl1)
            snapControl1.CreateNewDocument()
            AddHandler snapControl1.BeforeLoadCustomAssembly, AddressOf SnapControl1_BeforeLoadCustomAssembly
        End Sub

        Private Sub btnLoadTemplateWithData_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            ' Load template with data.
            If IO.File.Exists("test.snx") Then
                snapControl1.LoadDocument("test.snx")
                snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "Contacts"
            End If
        End Sub

        Private Sub tglShowWizardBrowseButton_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            ' Show the button in the Data Source Wizard to launch the "Browse for assembly" dialog. 
            snapControl1.Options.DataSourceWizardOptions.EFWizardSettings.ShowBrowseButton = tglShowWizardBrowseButton.Checked
        End Sub
    End Class
End Namespace
