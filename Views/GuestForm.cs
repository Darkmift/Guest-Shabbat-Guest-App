using Guest_Shabbat_Guest_App.DAL.Models;
using Guest_Shabbat_Guest_App.DAL.Repositories;
using Guest_Shabbat_Guest_App.Services;
using ReaLTaiizor.Forms;

namespace Guest_Shabbat_Guest_App
{
    internal partial class GuestForm : MaterialForm
    {
        private readonly GuestRepository _guestRepository;
        private readonly NavigationService _navigationService;
        private bool _isNaviagting = false;
        public GuestForm(GuestRepository guestRepository, NavigationService navigationService)
        {
            InitializeComponent();
            _guestRepository = guestRepository;
            _navigationService = navigationService;
            RefreshGuests();
        }

        public void label_addName_Click(object sender, EventArgs e)
        {
            string guestName = textbox_enterName.Text;
            if (string.IsNullOrWhiteSpace(guestName))
            {
                MessageBox.Show("נא להזין שם");
                return;
            }
            int? insertedId = _guestRepository.InsertAndReturnId(new GuestModel(guestName));
            if (insertedId == null)
            {
                MessageBox.Show("השם כבר קיים במערכת");
                return;
            }
            textbox_enterName.Text = string.Empty;
            RefreshGuests();

            GuestModel guest = _guestRepository.FindById((int)insertedId)!;

            _navigationService.ShowForm(FormNames.AddFoodForm, ref _isNaviagting, guest);
        }

        private void RefreshGuests()
        {
            dataGridView_guests.Rows.Clear();

            List<GuestModel> guests = _guestRepository.FindAll();
            foreach (GuestModel guest in guests)
            {
                // add guest.Name to the DataGridView and guest to the Tag property of the row
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = guest;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = guest.Name });
                dataGridView_guests.Rows.Add(row);
            }
        }

        private void dataGridView_guests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            GuestModel guest = (GuestModel)dataGridView_guests.Rows[index]?.Tag!;
            if (guest == null) return;

            MessageBox.Show($"Guest ID: {guest.Id}, Name: {guest.Name}");
            _navigationService.ShowForm(FormNames.AddFoodForm, ref _isNaviagting, guest);
        }
    }
}
