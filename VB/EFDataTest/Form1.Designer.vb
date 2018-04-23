Namespace EFDataTest
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject7 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject8 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.snapControl1 = New DevExpress.Snap.SnapControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.mailMergeDataSourceItem1 = New DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem()
            Me.commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.mailMergeCurrentRecordItem1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem()
            Me.repositoryItemMailMergeCurrentRecordEdit1 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
            Me.commandBarSubItem1 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem2 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem3 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.commandBarItem5 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.btnLoadTemplateWithData = New DevExpress.XtraBars.BarButtonItem()
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.dataRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataRibbonPageGroup()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.mailMergeRibbonPage1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup()
            Me.mailMergeCurrentRecordRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup()
            Me.finishAndMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup()
            Me.snapDockManager1 = New DevExpress.Snap.Extensions.SnapDockManager(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.fieldListDockPanel1 = New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
            Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.reportExplorerDockPanel1 = New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
            Me.reportExplorerDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.snapDocumentManager1 = New DevExpress.Snap.Extensions.SnapDocumentManager(Me.components)
            Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
            Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.fieldListDockPanel1.SuspendLayout()
            Me.reportExplorerDockPanel1.SuspendLayout()
            DirectCast(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' snapControl1
            ' 
            Me.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.snapControl1.Location = New System.Drawing.Point(0, 143)
            Me.snapControl1.MenuManager = Me.ribbonControl1
            Me.snapControl1.Name = "snapControl1"
            Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
            Me.snapControl1.Size = New System.Drawing.Size(584, 418)
            Me.snapControl1.TabIndex = 0
            Me.snapControl1.Text = "snapControl1"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.mailMergeDataSourceItem1, Me.commandBarCheckItem1, Me.commandBarCheckItem2, Me.mailMergeCurrentRecordItem1, Me.commandBarSubItem1, Me.commandBarItem1, Me.commandBarItem2, Me.commandBarItem3, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem4, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.showDocumentPropertiesFormItem1, Me.commandBarItem5, Me.btnLoadTemplateWithData})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 23
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.mailMergeRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMailMergeCurrentRecordEdit1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(784, 143)
            ' 
            ' mailMergeDataSourceItem1
            ' 
            Me.mailMergeDataSourceItem1.Id = 1
            Me.mailMergeDataSourceItem1.Name = "mailMergeDataSourceItem1"
            ' 
            ' commandBarCheckItem1
            ' 
            Me.commandBarCheckItem1.Id = 2
            Me.commandBarCheckItem1.Name = "commandBarCheckItem1"
            Me.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters
            ' 
            ' commandBarCheckItem2
            ' 
            Me.commandBarCheckItem2.Id = 3
            Me.commandBarCheckItem2.Name = "commandBarCheckItem2"
            Me.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting
            ' 
            ' mailMergeCurrentRecordItem1
            ' 
            Me.mailMergeCurrentRecordItem1.Description = resources.GetString("mailMergeCurrentRecordItem1.Description")
            Me.mailMergeCurrentRecordItem1.Edit = Me.repositoryItemMailMergeCurrentRecordEdit1
            Me.mailMergeCurrentRecordItem1.EditWidth = 90
            Me.mailMergeCurrentRecordItem1.Id = 4
            Me.mailMergeCurrentRecordItem1.Name = "mailMergeCurrentRecordItem1"
            ' 
            ' repositoryItemMailMergeCurrentRecordEdit1
            ' 
            Me.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = False
            Me.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, Nothing, True) _
            })
            Me.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1"
            ' 
            ' commandBarSubItem1
            ' 
            Me.commandBarSubItem1.Id = 5
            Me.commandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem3) _
            })
            Me.commandBarSubItem1.Name = "commandBarSubItem1"
            Me.commandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FinishAndMerge
            ' 
            ' commandBarItem1
            ' 
            Me.commandBarItem1.Id = 6
            Me.commandBarItem1.Name = "commandBarItem1"
            Me.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergeExportDocument
            ' 
            ' commandBarItem2
            ' 
            Me.commandBarItem2.Id = 7
            Me.commandBarItem2.Name = "commandBarItem2"
            Me.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrint
            ' 
            ' commandBarItem3
            ' 
            Me.commandBarItem3.Id = 8
            Me.commandBarItem3.Name = "commandBarItem3"
            Me.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrintPreview
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 9
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 10
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Id = 11
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Id = 12
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Id = 13
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Id = 14
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' commandBarItem4
            ' 
            Me.commandBarItem4.Id = 15
            Me.commandBarItem4.Name = "commandBarItem4"
            Me.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Id = 16
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 17
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 18
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' showDocumentPropertiesFormItem1
            ' 
            Me.showDocumentPropertiesFormItem1.Id = 19
            Me.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
            ' 
            ' commandBarItem5
            ' 
            Me.commandBarItem5.Id = 20
            Me.commandBarItem5.Name = "commandBarItem5"
            Me.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource
            ' 
            ' btnLoadTemplateWithData
            ' 
            Me.btnLoadTemplateWithData.Caption = "Load Template with Data"
            Me.btnLoadTemplateWithData.Glyph = (DirectCast(resources.GetObject("btnLoadTemplateWithData.Glyph"), System.Drawing.Image))
            Me.btnLoadTemplateWithData.Id = 21
            Me.btnLoadTemplateWithData.LargeGlyph = (DirectCast(resources.GetObject("btnLoadTemplateWithData.LargeGlyph"), System.Drawing.Image))
            Me.btnLoadTemplateWithData.Name = "btnLoadTemplateWithData"
            Me.btnLoadTemplateWithData.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.dataRibbonPageGroup1, Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' dataRibbonPageGroup1
            ' 
            Me.dataRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem5)
            Me.dataRibbonPageGroup1.ItemLinks.Add(Me.btnLoadTemplateWithData)
            Me.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' infoRibbonPageGroup1
            ' 
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.showDocumentPropertiesFormItem1)
            Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
            ' 
            ' mailMergeRibbonPage1
            ' 
            Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1, Me.mailMergeCurrentRecordRibbonPageGroup1, Me.finishAndMergeRibbonPageGroup1})
            Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
            ' 
            ' mailMergeRibbonPageGroup1
            ' 
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.mailMergeDataSourceItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem2)
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            ' 
            ' mailMergeCurrentRecordRibbonPageGroup1
            ' 
            Me.mailMergeCurrentRecordRibbonPageGroup1.ItemLinks.Add(Me.mailMergeCurrentRecordItem1)
            Me.mailMergeCurrentRecordRibbonPageGroup1.Name = "mailMergeCurrentRecordRibbonPageGroup1"
            ' 
            ' finishAndMergeRibbonPageGroup1
            ' 
            Me.finishAndMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem1)
            Me.finishAndMergeRibbonPageGroup1.Name = "finishAndMergeRibbonPageGroup1"
            ' 
            ' snapDockManager1
            ' 
            Me.snapDockManager1.Form = Me
            Me.snapDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
            Me.snapDockManager1.SnapControl = Me.snapControl1
            Me.snapDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
            Me.panelContainer1.Controls.Add(Me.reportExplorerDockPanel1)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("910cd1fc-45e3-49f4-a6fc-c37f1d64d6bb")
            Me.panelContainer1.Location = New System.Drawing.Point(584, 143)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(200, 418)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' fieldListDockPanel1
            ' 
            Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
            Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.ID = New System.Guid("4f12cffb-84fd-4348-9476-f842b537d674")
            Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
            Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 210)
            Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 209)
            Me.fieldListDockPanel1.SnapControl = Me.snapControl1
            ' 
            ' fieldListDockPanel1_Container
            ' 
            Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(5, 23)
            Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(191, 181)
            Me.fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' reportExplorerDockPanel1
            ' 
            Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
            Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.reportExplorerDockPanel1.ID = New System.Guid("a53268b2-a11d-4ac2-a5f2-ecd908c2bdc1")
            Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(0, 209)
            Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
            Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 210)
            Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(200, 209)
            Me.reportExplorerDockPanel1.SnapControl = Me.snapControl1
            ' 
            ' reportExplorerDockPanel1_Container
            ' 
            Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(5, 23)
            Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
            Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(191, 182)
            Me.reportExplorerDockPanel1_Container.TabIndex = 0
            ' 
            ' snapDocumentManager1
            ' 
            Me.snapDocumentManager1.ClientControl = Me.snapControl1
            Me.snapDocumentManager1.View = Me.noDocumentsView1
            Me.snapDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1})
            ' 
            ' snapBarController1
            ' 
            Me.snapBarController1.BarItems.Add(Me.mailMergeDataSourceItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem2)
            Me.snapBarController1.BarItems.Add(Me.mailMergeCurrentRecordItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem2)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem3)
            Me.snapBarController1.BarItems.Add(Me.undoItem1)
            Me.snapBarController1.BarItems.Add(Me.redoItem1)
            Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
            Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem4)
            Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.snapBarController1.BarItems.Add(Me.printItem1)
            Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.snapBarController1.BarItems.Add(Me.showDocumentPropertiesFormItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem5)
            Me.snapBarController1.Control = Me.snapControl1
            Me.snapBarController1.RibbonControl = Me.ribbonControl1
            Me.snapBarController1.SnapDockManager = Me.snapDockManager1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.snapControl1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.fieldListDockPanel1.ResumeLayout(False)
            Me.reportExplorerDockPanel1.ResumeLayout(False)
            DirectCast(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private snapControl1 As DevExpress.Snap.SnapControl
        Private snapDockManager1 As DevExpress.Snap.Extensions.SnapDockManager
        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Private fieldListDockPanel1 As DevExpress.Snap.Extensions.UI.FieldListDockPanel
        Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private reportExplorerDockPanel1 As DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel
        Private reportExplorerDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private snapDocumentManager1 As DevExpress.Snap.Extensions.SnapDocumentManager
        Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private mailMergeDataSourceItem1 As DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem
        Private commandBarCheckItem1 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem2 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private mailMergeCurrentRecordItem1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem
        Private repositoryItemMailMergeCurrentRecordEdit1 As DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
        Private commandBarSubItem1 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem2 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem3 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private commandBarItem4 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private showDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Private commandBarItem5 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Private infoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
        Private dataRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataRibbonPageGroup
        Private mailMergeRibbonPage1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPage
        Private mailMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup
        Private mailMergeCurrentRecordRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup
        Private finishAndMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup
        Private snapBarController1 As DevExpress.Snap.Extensions.SnapBarController
        Private WithEvents btnLoadTemplateWithData As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

