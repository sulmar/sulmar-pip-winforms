using Microsoft.Extensions.Configuration;
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

            yearTextBox.Text = DateTime.Today.Year.ToString();
        }

        private void GetInspectorsBySearchCriteriaButton_Click(object sender, EventArgs e)
        {
            // TODO: Przenieś do pliku konfiguracyjnego
            string connectionString = Program.Configuration.GetConnectionString("InspectorDb");

            IInspectorRepository repository = new DbInspectorRepository(new Microsoft.Data.SqlClient.SqlConnection(connectionString));

            if (int.TryParse(yearTextBox.Text, out int year))
            {
                var inspectors = repository.GetByYear(year);

                InspectorsDataGridView.DataSource = inspectors;
            }

        }
    }
}
