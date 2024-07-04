using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Abstractions;
using WinFormsApp.Infrastructure;

namespace WinFormsApp.Views
{
    public partial class InspectorsView : Form
    {
        public InspectorsView()
        {
            InitializeComponent();
        }

        private void GetInspectorsBySearchCriteriaButton_Click(object sender, EventArgs e)
        {
            IInspectorRepository repository = new FakeInspectorRepository();

            var inspectors = repository.GetAll();

            InspectorsDataGridView.DataSource = inspectors;

        }
    }
}
