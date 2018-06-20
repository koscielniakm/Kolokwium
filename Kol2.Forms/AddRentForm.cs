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
    public partial class AddRentForm : Form
    {

        private MainForm RootForm;

        private Kol2Context Context;

        public AddRentForm(MainForm RootForm)
        {
            this.Context = new Kol2Context();
            this.RootForm = RootForm;
            InitializeComponent();
        }

        private void AddRentForm_Load(object sender, EventArgs e)
        {

        }

        private void AddRentBtn_Click(object sender, EventArgs e)
        {
            DateTime RentDate = RentDateTimePicker.Value;
            DateTime ReturnDate = ReturnDateTimePicker.Value;
            int BikeId = Int32.Parse(BikeIdBox.Text);

            Rent AddedRent = new Rent();
            AddedRent.RentDate = RentDate;
            AddedRent.ReturnDate = ReturnDate;
            AddedRent.BikeId = BikeId;

            if (BikeId > 0 && RentDate != null && ReturnDate != null)
            {
                Context.Rents.Add(AddedRent);
                Context.SaveChanges();

                RentAccess RentAccess = new RentAccess();
                var DataSource = RentAccess.GetRents();
                RootForm.RentsGridView.DataSource = DataSource;
                RootForm.RentsGridView.Refresh();
                Hide();
            }
        }
    }
}
