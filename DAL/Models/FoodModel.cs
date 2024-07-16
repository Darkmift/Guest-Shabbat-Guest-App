using System.Data;

namespace Guest_Shabbat_Guest_App.DAL.Models
{
    internal class FoodModel
    {
        public int? ID;
        public string Name;
        public int Guest_ID;
        public int Category_ID;
        public string? GuestName;

        public FoodModel(int? id, string name, int guest_id, int category_id, string? guestName = null)
        {
            ID = id;
            Name = name;
            Guest_ID = guest_id;
            Category_ID = category_id;
            GuestName = guestName;
        }
        public FoodModel(string name, int guest_id, int category_id, string? guestName = null)
        {
            Name = name;
            Guest_ID = guest_id;
            Category_ID = category_id;
            GuestName = guestName;
        }

        public FoodModel(DataRow dataRow)
        {
            string? name = dataRow["Name"].ToString();
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name is missing");

            ID = (int)dataRow["ID"];
            Name = name;
            Guest_ID = (int)dataRow["Guest_ID"];
            Category_ID = (int)dataRow["Category_ID"];
            GuestName = dataRow["GuestName"].ToString();
        }
    }
}
