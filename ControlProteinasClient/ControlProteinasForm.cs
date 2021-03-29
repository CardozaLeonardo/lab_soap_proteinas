using ControlProteinasClient.ServicioControlProteinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProteinasClient
{
    public partial class ControlProteinasForm : Form
    {
        private ProteinTrackingServiceSoapClient service = new ProteinTrackingServiceSoapClient();
        private User[] users;
        public ControlProteinasForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            users = service.ListUsers();
            usersCombo.DataSource = users;
            usersCombo.DisplayMember = "Name";
            usersCombo.ValueMember = "UserId";
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            service.AddUser(nameField.Text, int.Parse(metaField.Text));
            users = service.ListUsers();
            usersCombo.DataSource = users;
        }

        private void usersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = usersCombo.SelectedIndex;
            totalLabel.Text = users[index].Total.ToString();
            metaLabel.Text = users[index].Goal.ToString();
        }

        private void OnAddProteina(object sender, EventArgs e)
        {
            var userId = users[usersCombo.SelectedIndex].UserId;
            var newTotal = service.AddProtein(int.Parse(totalProteinaField.Text), userId);
            users[usersCombo.SelectedIndex].Total = newTotal;
            totalLabel.Text = newTotal.ToString();
        }
    }
}
