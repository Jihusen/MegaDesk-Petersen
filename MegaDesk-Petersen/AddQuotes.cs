using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Petersen
{
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();

            //width validation
            try
            {

                double widthSubmit = double.Parse(widthInput.Text);
                if (widthSubmit > 0 && widthSubmit <= 15)
                {
                    desk.Width = double.Parse(widthInput.Text.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please enter a width between 1ft and 15ft", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //depth validation

        }
    }
}
