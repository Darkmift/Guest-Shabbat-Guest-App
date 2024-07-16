using System.Data;

namespace Guest_Shabbat_Guest_App.DAL.Models
{
    internal class GuestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GuestModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public GuestModel(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name is missing");

            Name = name;
        }

        public GuestModel(DataRow dataRow)
        {
            string? name = dataRow["Name"].ToString();
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name is missing");

            Id = (int)dataRow["ID"];
            Name = name;
        }
    }
}
