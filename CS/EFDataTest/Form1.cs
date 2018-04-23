using DevExpress.DataAccess.UI.Wizard.Services;
using DevExpress.Snap.Core.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace EFDataTest {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            // Prompt for loading a data assembly; default is NeverLoad.
            this.snapControl1.Options.DataSourceLoadingOptions.EFCustomAssemblyBehavior = DevExpress.DataAccess.EntityFramework.CustomAssemblyBehavior.Prompt;
			//// Uncomment the string below to disable browsing for a custom assembly in the Data Source Wizard.
            //this.snapControl1.Options.DataSourceWizardOptions.EFWizardSettings.CustomAssemblyBehavior = DevExpress.DataAccess.EntityFramework.CustomAssemblyBehavior.NeverLoad;
            // Handle this event to decide whether to load a custom data assembly.
            this.snapControl1.CustomAssemblyLoading += SnapControl1_CustomAssemblyLoading;
            // The service is employed in the Data Source Wizard.
            this.snapControl1.ReplaceService<ICustomAssemblyPathNotifier>(new myCustomAssemblyPathNotifier());
            // The service is employed when loading a template.
            this.snapControl1.ReplaceService<ICustomAssemblyLoadingNotificationService>(new myCustomAssemblyLoadingNotificationService());
        }

        private void SnapControl1_CustomAssemblyLoading(object sender, DevExpress.DataAccess.CustomAssemblyLoadingEventArgs e) {
            // Decide whether to load a custom assembly.
            e.Cancel = MessageBox.Show(String.Format("Do you want to load data from {0}?", e.Path),
                    "Security Warning", MessageBoxButtons.YesNo) == DialogResult.No;
            // Decide whether to query the service for the final decision.
            e.Handled = MessageBox.Show(String.Format("Is this your final decision?", e.Path),
                    "Security Warning", MessageBoxButtons.YesNo) == DialogResult.Yes; ;
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create test.snx template and save it.
            MyHelper.CreateAndSaveReportTemplate(this.snapControl1);
            this.snapControl1.CreateNewDocument();
        }

        private void btnLoadTemplateWithData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (System.IO.File.Exists("test.snx")) {
                this.snapControl1.LoadDocument("test.snx");
                this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "Contacts";
            }
        }
    }

    public class myCustomAssemblyLoadingNotificationService : ICustomAssemblyLoadingNotificationService {
        public bool RequestApproval(string assemblyPath) {
                return MessageBox.Show(String.Format("Are you sure?\nLoading {0}", assemblyPath), 
                    "Final Security Control Warning", MessageBoxButtons.OKCancel) == DialogResult.OK;
            }
        }

    public class myCustomAssemblyPathNotifier : ICustomAssemblyPathNotifier {
        public bool RequestApproval(string assemblyPath, XtraForm owner) {
            return MessageBox.Show(String.Format("Are you sure?\nLoading {0}", assemblyPath),
                "Final Security Wizard Warning", MessageBoxButtons.OKCancel) == DialogResult.OK;
        }
    }
}
