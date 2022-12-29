using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class MainForm : Form
    {
        HistoryMenu menuHistory = new Final_Project_PBO_1.HistoryMenu();
        HomeMenu menuHome = new Final_Project_PBO_1.HomeMenu();
        CheckOutMenu menuCheckOut = new Final_Project_PBO_1.CheckOutMenu();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

            private void btnHome_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Remove(menuHistory);
            this.panel3.Controls.Remove(menuCheckOut);
            this.panel3.Controls.Add(menuHome);

            menuHome.Location = new System.Drawing.Point(0, 0);
            menuHome.Name = "homeMenu1";
            menuHome.Size = new System.Drawing.Size(1249, 704);
            menuHome.TabIndex = 0;

            menuHome.HomeMenu_Load(sender,e);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Remove(menuHome);
            this.panel3.Controls.Remove(menuCheckOut);
            this.panel3.Controls.Add(menuHistory);

            menuHistory.Location = new System.Drawing.Point(0, 0);
            menuHistory.Name = "historyMenu1";
            menuHistory.Size = new System.Drawing.Size(1249, 704);
            menuHistory.TabIndex = 0;

            menuHistory.HistoryMenu_Load(sender,e);
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Remove(menuHome);
            this.panel3.Controls.Remove(menuHistory);
            this.panel3.Controls.Add(menuCheckOut);

            menuCheckOut.Location = new System.Drawing.Point(0, 0);
            menuCheckOut.Name = "COMenu1";
            menuCheckOut.Size = new System.Drawing.Size(1249, 704);
            menuCheckOut.TabIndex = 0;

            menuCheckOut.CheckOutMenu_Load(sender,e);   
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var backtologinpage = new LoginPage();

                this.Hide();

                backtologinpage.Show();
            }
        }
    }
}
