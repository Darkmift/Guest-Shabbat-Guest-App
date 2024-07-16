using System.Data;

namespace Guest_Shabbat_Guest_App.DAL.Models
{
    internal class CategoryModel
    {
        public string CategoryName { get; set; }
        public int? CategoryID { get; set; }

        public CategoryModel(string categoryName, int? categoryID)
        {
            CategoryName = categoryName;
            CategoryID = categoryID;
        }

        // ctor from datarow
        public CategoryModel(DataRow row)
        {
            if (row == null || row["Name"] == null)
            {
                throw new System.ArgumentNullException(nameof(row));
            }
            CategoryName = row["Name"].ToString()!;
            CategoryID = (int)row["ID"];
        }
    }

}
