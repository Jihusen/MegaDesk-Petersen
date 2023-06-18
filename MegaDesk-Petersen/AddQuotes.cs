using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            DeskQuote newQuote = new DeskQuote();
            int material = 0;

            // all entered validation
            try
            {
                if (nameInput != null)
                {
                    newQuote.CustName = nameInput.Text;
                }
                if (widthInput != null)
                {
                    desk.Width = double.Parse(widthInput.Text.ToString());
                }

                if (depthInput != null)
                {
                    desk.Depth = double.Parse(depthInput.Text.ToString());
                }

                if (drawersInput != null)
                {
                    desk.DrawersNum = uint.Parse(drawersInput.SelectedItem.ToString());
                }

                
                if (materialInput != null)
                {
                    string selectedMaterial = materialInput.SelectedItem.ToString();
                    
                    switch (selectedMaterial)
                    {
                        case "Oak":
                            material = (int)DesktopMaterial.Oak;
                            break;
                        case "Rosewood":
                            material = (int)DesktopMaterial.Rosewood;
                            break;
                        case "Laminate":
                            material = (int)DesktopMaterial.Laminate;
                            break;
                        case "Veneer":
                            material = (int)DesktopMaterial.Veneer;
                            break;
                        case "Pine":
                            material = (int)DesktopMaterial.Pine;
                            break;
                    }
                }

                if (rushInput != null)
                {
                    newQuote.RushOrder = uint.Parse(rushInput.SelectedItem.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please enter a value in every field", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            double surfaceArea = newQuote.calcSurfaceArea(desk.Width, desk.Depth);
            double shipping = newQuote.calcShippingCost(surfaceArea, newQuote.RushOrder);
            DateTime quoteDate = DateTime.Today;
            newQuote.QuoteDate = quoteDate;

            double quoteTotal = newQuote.QuoteTotal(material, shipping, surfaceArea, desk.DrawersNum);

            StreamWriter writeQuote = new StreamWriter("newQuote.txt");
            writeQuote.WriteLine(newQuote.CustName);
            writeQuote.WriteLine(newQuote.QuoteDate);
            writeQuote.WriteLine("$" + quoteTotal);
            writeQuote.Close();

            DisplayQuote displayNewQuoteForm = new DisplayQuote();
            displayNewQuoteForm.Tag = this;
            displayNewQuoteForm.Show(this);
            Hide();

        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            if (widthInput.Text.Length > 0)
            {
                string widthError = "Please enter a number between 1 and 15";
                double widthSubmit = double.Parse(widthInput.Text);
                if (widthSubmit < 0 || widthSubmit > 15)
                {
                    e.Cancel = true;
                    widthInput.Select(0, widthInput.Text.Length);

                    this.WrongWidth.SetError(widthInput, widthError);
                }
            }
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*char depthString = Convert.ToChar(depthInput.Text);
            if (!Char.IsDigit(depthChar) && !Char.IsControl(depthChar))
            if (!Char.IsDigit(depthChar) && !Char.IsControl(depthChar))
            {
                depthInput.Text = String.Empty;
                MessageBox.Show("Please enter a number!");
            }*/

        }
    }
}
