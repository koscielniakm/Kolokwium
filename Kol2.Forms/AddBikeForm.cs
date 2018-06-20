using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kol2.BLL;
using Kol2.DAL;

namespace Kol2.Forms
{
    public partial class AddBikeForm : Form
    {

        private MainForm RootForm;

        private Kol2Context Context;
        
        public AddBikeForm(MainForm RootForm)
        {
            this.Context = new Kol2Context();
            this.RootForm = RootForm;
            InitializeComponent();
        }

        private void AddBikeBtn_Click(object sender, EventArgs e)
        {
            string BikeNumber = TextBoxNumber.Text;
            string BikeType = TextBoxType.Text;

            Bike AddedBike = new Bike();
            AddedBike.Number = BikeNumber;
            AddedBike.Type = BikeType;

            if (BikeNumber != "" && BikeType != "")
            {
                //Database
                Context.Bikes.Add(AddedBike);
                Context.SaveChanges();
                //Forms
                BikeAccess BikeAccess = new BikeAccess();
                var DataSource = BikeAccess.GetBikes();
                RootForm.BikesGridView.DataSource = DataSource;
                RootForm.BikesGridView.Refresh();
                Hide();
            }
            else
            {
                MessageBox.Show("Incompleted data.");
            }

        }

        private void AddBikeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
