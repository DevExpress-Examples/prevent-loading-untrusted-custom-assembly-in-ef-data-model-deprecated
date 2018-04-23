using System;
using System.Windows.Forms;

namespace EFDataTest {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            // Handle this event to decide whether this application allows loading a custom data assembly.
            DevExpress.DataAccess.EntityFramework.EFDataSource.BeforeLoadCustomAssemblyGlobal += EFDataSource_BeforeLoadCustomAssemblyGlobal;
            // Handle this event to allow loading a custom data assembly when the SnapControl queries the data source.
            this.snapControl1.BeforeLoadCustomAssembly += SnapControl1_BeforeLoadCustomAssembly;
    }

        private void EFDataSource_BeforeLoadCustomAssemblyGlobal(object sender, DevExpress.DataAccess.EntityFramework.BeforeLoadCustomAssemblyEventArgs args) {
            args.AllowLoading = true;
        }

        private void SnapControl1_BeforeLoadCustomAssembly(object sender, DevExpress.DataAccess.EntityFramework.BeforeLoadCustomAssemblyEventArgs args) {
            // Decide whether to load a custom assembly.
            args.AllowLoading = MessageBox.Show(String.Format("Do you want to load data from {0}?", args.AssemblyPath),
                    "Snap Security Warning", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create test.snx template and save it.
            MyHelper.CreateAndSaveReportTemplate(this.snapControl1);
            this.snapControl1.CreateNewDocument();
            this.snapControl1.BeforeLoadCustomAssembly += SnapControl1_BeforeLoadCustomAssembly;
        }

        private void btnLoadTemplateWithData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Load template with data.
            if (System.IO.File.Exists("test.snx")) {
                this.snapControl1.LoadDocument("test.snx");
                this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "Contacts";
            }
        }

        private void tglShowWizardBrowseButton_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Show the button in the Data Source Wizard to launch the "Browse for assembly" dialog. 
            this.snapControl1.Options.DataSourceWizardOptions.EFWizardSettings.ShowBrowseButton = tglShowWizardBrowseButton.Checked;
        }
    }
}
