using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
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

            string secretKey = Environment.GetEnvironmentVariable("MY_SECRET_KEY");

            // var result = Microsoft.Win32.Registry.GetValue("a", "b", 0);

            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            var username = identity.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;

            // var email = identity.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;

            WindowsPrincipal principal = new WindowsPrincipal(identity);

            if (principal.IsInRole("trainer"))
            {

            }

            // dotnet add package System.DirectoryServices.AccountManagement
            PrincipalContext context = new PrincipalContext(ContextType.Machine);

            UserPrincipal user = UserPrincipal.FindByIdentity(context, username);

            var name = user.DisplayName;

            GroupPrincipal group = GroupPrincipal.FindByIdentity(context, IdentityType.Name, "Administratorzy");

            if (group != null)
            {
                foreach (Principal p in group.GetMembers(true))
                {
                    Console.WriteLine(p.Name);
                }
            }

        }
    }
}
