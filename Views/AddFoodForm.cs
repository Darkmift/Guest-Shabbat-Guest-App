using Guest_Shabbat_Guest_App.DAL.Models;
using Guest_Shabbat_Guest_App.DAL.Repositories;
using Guest_Shabbat_Guest_App.Services;
using ReaLTaiizor.Forms;

namespace Guest_Shabbat_Guest_App.Views
{
    internal partial class AddFoodForm : MaterialForm
    {
        private readonly FoodRepository _foodRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly GuestModel _currentGuest;
        private readonly NavigationService _navigationService;
        private CategoryModel _selectedCategory;
        public AddFoodForm(FoodRepository foodRepository, CategoryRepository categoryRepository, GuestModel guest, NavigationService navigationService)
        {
            InitializeComponent();
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
            _currentGuest = guest;
            _navigationService = navigationService;
            var categories = _categoryRepository.FindAll();
            if (categories.Count > 0)
            {
                _selectedCategory = categories[0];
                RefreshFoods((int)_selectedCategory.CategoryID!);
                LoadCategories(categories);
            }
        }

        private void LoadCategories(List<CategoryModel> categories)
        {
            dataGridView_categories.Rows.Clear();

            foreach (CategoryModel category in categories)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = category;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = category.CategoryName });
                dataGridView_categories.Rows.Add(row);
            }
        }

        private void RefreshFoods(int selectedCategoryId)
        {
            dataGridView_foods.Rows.Clear();
            List<FoodModel> foods = _foodRepository.FindAllJoinedWithGuests(selectedCategoryId);
            foreach (FoodModel food in foods)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = food;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = food.Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = food.GuestName });
                dataGridView_foods.Rows.Add(row);
            }
        }

        private void dataGridView_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the selected category
            int index = e.RowIndex;
            if (index < 0) return;
            _selectedCategory = (CategoryModel)dataGridView_categories.Rows[index]?.Tag!;
            if (_selectedCategory == null) return;
            RefreshFoods((int)_selectedCategory.CategoryID!);
        }

        private void label_addFood_Click(object sender, EventArgs e)
        {
            string foodName = textbox_addFood.Text;
            string message = foodName switch
            {
                _ when string.IsNullOrWhiteSpace(foodName) => "נא להזין מאכל",
                _ when _selectedCategory == null => "נא לבחור קטגוריה",
                _ => string.Empty
            };
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            FoodModel food = new FoodModel(null, foodName, _currentGuest.Id, (int)_selectedCategory.CategoryID!);
            bool isInserted = _foodRepository.Insert(food);
            if (!isInserted)
            {
                MessageBox.Show("המאכל כבר קיים במערכת");
                return;
            }
            textbox_addFood.Text = string.Empty;
            RefreshFoods((int)_selectedCategory.CategoryID!);
        }
    }
}
