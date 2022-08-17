Imports DevExpress.DataAccess.EntityFramework
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Windows.Forms

Namespace EFDataTest

    Public Module MyHelper

        Public Sub CreateAndSaveReportTemplate(ByVal control As SnapControl)
            Call GenerateLayout(control.Document)
            control.Document.DataSource = CreateEFDataSource()
            control.SaveDocument("test.snx")
        End Sub

        Private Function CreateEFDataSource() As Object
#Region "#CreateEFDataSource"
            Dim ds As EFDataSource = New EFDataSource(New EFConnectionParameters())
            ds.Name = "Contacts"
            ds.ConnectionParameters.CustomAssemblyPath = Application.StartupPath & "\EFDataModel.dll"
            ds.ConnectionParameters.CustomContextName = "EFDataModel.ContactsEntities"
            ds.ConnectionParameters.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Contacts.mdf;integrated security=True;"
#End Region  ' #CreateEFDataSource
            Return ds
        End Function

#Region "#GenerateLayout"
        Private Sub GenerateLayout(ByVal doc As SnapDocument)
            ' Delete the document's content.
            doc.Text = String.Empty
            ' Add a Snap list to the document.
            Dim list As SnapList = doc.CreateSnList(doc.Range.End, "CustomerList")
            list.BeginUpdate()
            list.DataMember = "Customers"
            ' Add a header to the Snap list.                                                                   
            Dim listHeader As SnapDocument = list.ListHeader
            Dim listHeaderTable As Table = listHeader.Tables.Create(listHeader.Range.End, 1, 3)
            Dim listHeaderCells As TableCellCollection = listHeaderTable.FirstRow.Cells
            listHeader.InsertText(listHeaderCells(0).ContentRange.End, "First Name")
            listHeader.InsertText(listHeaderCells(1).ContentRange.End, "Last Name")
            listHeader.InsertText(listHeaderCells(2).ContentRange.End, "Company")
            ' Customize the row template.
            Dim listRow As SnapDocument = list.RowTemplate
            Dim listRowTable As Table = listRow.Tables.Create(listRow.Range.End, 1, 3)
            Dim listRowCells As TableCellCollection = listRowTable.FirstRow.Cells
            listRow.CreateSnText(listRowCells(0).ContentRange.End, "FirstName")
            listRow.CreateSnText(listRowCells(1).ContentRange.End, "LastName")
            listRow.CreateSnText(listRowCells(2).ContentRange.End, "Company")
            FormatList(list)
            list.EndUpdate()
            list.Field.Update()
        End Sub

        Private Sub FormatList(ByVal list As SnapList)
            ' Customize the list header.
            Dim header As SnapDocument = list.ListHeader
            Dim headerTable As Table = header.Tables(0)
            For Each row As TableRow In headerTable.Rows
                For Each cell As TableCell In row.Cells
                    ' Apply cell formatting.
                    cell.Borders.Left.LineColor = System.Drawing.Color.White
                    cell.Borders.Right.LineColor = System.Drawing.Color.White
                    cell.Borders.Top.LineColor = System.Drawing.Color.White
                    cell.Borders.Bottom.LineColor = System.Drawing.Color.White
                    cell.BackgroundColor = System.Drawing.Color.SteelBlue
                    ' Apply text formatting.
                    Dim formatting As CharacterProperties = header.BeginUpdateCharacters(cell.ContentRange)
                    formatting.Bold = True
                    formatting.ForeColor = System.Drawing.Color.White
                    header.EndUpdateCharacters(formatting)
                Next
            Next
        End Sub
#End Region  ' #GenerateLayout
    End Module
End Namespace
