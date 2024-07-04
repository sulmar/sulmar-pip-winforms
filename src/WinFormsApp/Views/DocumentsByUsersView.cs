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
using WinFormsApp.Models;

namespace WinFormsApp.Views
{
    public partial class DocumentsByUsersView : Form
    {
        public DocumentsByUsersView()
        {
            InitializeComponent();
        }

        private void GetInforButton_Click(object sender, EventArgs e)
        {
            string connectionString = Program.Configuration.GetConnectionString("InspectorDb");
            IUserRepository userRepository = new DbUserRepository(new Microsoft.Data.SqlClient.SqlConnection(connectionString));
            List<DocumentsByUser> documentsByUsers = userRepository.GetByPeriod(FromDateTimePicker.Value, ToDateTimePicker.Value);
            DocumentsByUsersdataGridView.DataSource = documentsByUsers;
        }
    }
}
