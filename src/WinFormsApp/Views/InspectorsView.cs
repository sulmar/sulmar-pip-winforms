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
            // TODO: Przenieś do pliku konfiguracyjnego
            string connectionString = "Data Source=DESKTOP-RB5EAJ4\\SQLEXPRESS;Initial Catalog=InspectorsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            IInspectorRepository repository = new DbInspectorRepository(new Microsoft.Data.SqlClient.SqlConnection(connectionString));

            var inspectors = repository.GetAll();

            InspectorsDataGridView.DataSource = inspectors;

        }
    }
}
