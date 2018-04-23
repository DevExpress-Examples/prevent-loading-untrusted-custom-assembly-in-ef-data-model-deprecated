using DevExpress.DataAccess.EntityFramework;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDataTest {
    public static class MyHelper {

        public static void CreateAndSaveReportTemplate(SnapControl control) {
            GenerateLayout(control.Document);
            control.Document.DataSource = CreateEFDataSource();
            control.SaveDocument("test.snx");
        }

        private static object CreateEFDataSource() {
            #region #CreateEFDataSource
            EFDataSource ds = new EFDataSource(new EFConnectionParameters());
            ds.Name = "Contacts";
            ds.ConnectionParameters.CustomAssemblyPath = Application.StartupPath + @"\EFDataModel.dll";
            ds.ConnectionParameters.CustomContextName = "EFDataModel.ContactsEntities";
            ds.ConnectionParameters.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Contacts.mdf;integrated security=True;";
            ds.Fill();
            #endregion #CreateEFDataSource
            return ds;
        }

        #region #GenerateLayout
        private static void GenerateLayout(SnapDocument doc) {
            // Delete the document's content.
            doc.Text = String.Empty;
            // Add a Snap list to the document.
            SnapList list = doc.CreateSnList(doc.Range.End, "CustomerList");
            list.BeginUpdate();
            list.DataMember = "Customers";

            // Add a header to the Snap list.                                                                   
            SnapDocument listHeader = list.ListHeader;
            Table listHeaderTable = listHeader.Tables.Create(listHeader.Range.End, 1, 3);
            TableCellCollection listHeaderCells = listHeaderTable.FirstRow.Cells;
            listHeader.InsertText(listHeaderCells[0].ContentRange.End, "First Name");
            listHeader.InsertText(listHeaderCells[1].ContentRange.End, "Last Name");
            listHeader.InsertText(listHeaderCells[2].ContentRange.End, "Company");

            // Customize the row template.
            SnapDocument listRow = list.RowTemplate;
            Table listRowTable = listRow.Tables.Create(listRow.Range.End, 1, 3);
            TableCellCollection listRowCells = listRowTable.FirstRow.Cells;
            listRow.CreateSnText(listRowCells[0].ContentRange.End, @"FirstName");
            listRow.CreateSnText(listRowCells[1].ContentRange.End, @"LastName");
            listRow.CreateSnText(listRowCells[2].ContentRange.End, @"Company");

            FormatList(list);

            list.EndUpdate();
            list.Field.Update();
        }

        private static void FormatList(SnapList list) {
            // Customize the list header.
            SnapDocument header = list.ListHeader;
            Table headerTable = header.Tables[0];

            foreach (TableRow row in headerTable.Rows) {
                foreach (TableCell cell in row.Cells) {
                    // Apply cell formatting.
                    cell.Borders.Left.LineColor = System.Drawing.Color.White;
                    cell.Borders.Right.LineColor = System.Drawing.Color.White;
                    cell.Borders.Top.LineColor = System.Drawing.Color.White;
                    cell.Borders.Bottom.LineColor = System.Drawing.Color.White;
                    cell.BackgroundColor = System.Drawing.Color.SteelBlue;

                    // Apply text formatting.
                    CharacterProperties formatting = header.BeginUpdateCharacters(cell.ContentRange);
                    formatting.Bold = true;
                    formatting.ForeColor = System.Drawing.Color.White;
                    header.EndUpdateCharacters(formatting);
                }
            }
        }
        #endregion #GenerateLayout
    }
}
