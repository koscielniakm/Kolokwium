using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kol2.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rentBikeDataSet1.Rents' . Możesz go przenieść lub usunąć.
            this.rentsTableAdapter.Fill(this.rentBikeDataSet1.Rents);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rentBikeDataSet.Bikes' . Możesz go przenieść lub usunąć.
            this.bikesTableAdapter.Fill(this.rentBikeDataSet.Bikes);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bikesTableAdapter.FillBy(this.rentBikeDataSet.Bikes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BikesGridView.DataSource = new Object();
            BikesGridView.Refresh();
            RentsGridView.DataSource = new Object();
            RentsGridView.Refresh();
        }

        private void AddBikeBtn_Click(object sender, EventArgs e)
        {
            new AddBikeForm(this).Show();
        }

        private void BikesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddRentBtn_Click(object sender, EventArgs e)
        {
            new AddRentForm(this).Show();
        }
    }
}
