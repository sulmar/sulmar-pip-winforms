using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Views
{
    public partial class ShellView : Form
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void ShowInspectorsButton_Click(object sender, EventArgs e)
        {
            var view = new InspectorsView();
            view.Show();

        }

        private void ShowDocumentsButton_Click(object sender, EventArgs e)
        {
            var view = new DocumentsByUsersView();
            view.Show();
        }
    }
}
