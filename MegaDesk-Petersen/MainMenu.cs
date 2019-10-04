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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuotes addNewQuoteForm = new AddQuotes();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuotesForm = new SearchQuotes();
            addSearchQuotesForm.Tag = this;
            addSearchQuotesForm.Show(this);
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuotes_Click(object sender, EventArgs e)
        {
            DisplayQuote addDisplayQuoteForm = new DisplayQuote();
            addDisplayQuoteForm.Tag = this;
            addDisplayQuoteForm.Show(this);
            Hide();
        }
    }
}
