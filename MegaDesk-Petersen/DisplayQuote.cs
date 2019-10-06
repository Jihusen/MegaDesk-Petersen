using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Petersen
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();

            
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void SeeQuote_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("newQuote.txt");
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                ReadFile.Text += line + " ";
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}
