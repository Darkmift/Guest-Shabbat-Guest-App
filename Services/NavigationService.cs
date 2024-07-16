using Guest_Shabbat_Guest_App.DAL;
using Guest_Shabbat_Guest_App.DAL.Models;
using Guest_Shabbat_Guest_App.DAL.Repositories;
using Guest_Shabbat_Guest_App.Views;

namespace Guest_Shabbat_Guest_App.Services
{
    public enum FormNames
    {
        GuestForm,
        AddFoodForm,
    }

    internal class NavigationService
    {

        private readonly DBContext _dBContext;
        public NavigationService(DBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void HandleCloseFormEvent(object sender, FormClosingEventArgs e, bool isNavigating)
        {
            if (!isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                string confirmExitQuestion = "האם ברצונך לצאת מהמערכת?";
                string confirmExitTitle = "אשר יציאה מהמערכת";
                DialogResult dialogResult = MessageBox.Show(confirmExitQuestion, confirmExitTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
                e.Cancel = true;
            }
        }

        public void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            openForms.ForEach(f => f.Close());
        }

        public void ShowForm(FormNames formName)
        {
            bool isNavigating = true;
            ShowForm(formName, ref isNavigating);
        }

        private void ShowForm(FormNames formName, ref bool isNavigating)
        {
            ShowForm(formName, ref isNavigating, null!);
        }

        public void ShowForm(FormNames formName, ref bool isNavigating, GuestModel guest)
        {
            isNavigating = true;
            CloseAllForms();


            Form form = formName switch
            {
                FormNames.GuestForm => new GuestForm(new GuestRepository(_dBContext), this),
                FormNames.AddFoodForm => new AddFoodForm(new FoodRepository(_dBContext), new CategoryRepository(_dBContext), guest, this),
                _ => throw new ArgumentException("Invalid form name.", nameof(formName))
            };
            form.Show();
        }

    }
}
