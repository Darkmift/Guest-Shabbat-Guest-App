using Guest_Shabbat_Guest_App.DAL.Models;
using System.Data;
using System.Data.SqlClient;

namespace Guest_Shabbat_Guest_App.DAL.Repositories
{
    internal class GuestRepository : IRepository<GuestModel>
    {
        private DBContext _dbContext;

        public GuestRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM Guests WHERE ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public List<GuestModel> FindAll()
        {
            List<GuestModel> guests = new();
            string query = "SELECT ID, Name FROM Guests";
            DataTable result = _dbContext.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
                guests.Add(new GuestModel(row));

            return guests;
        }

        public GuestModel? FindById(int id)
        {
            string query = "SELECT ID, Name FROM Guests WHERE ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            DataTable result = _dbContext.ExecuteQuery(query, parameters);

            return result.Rows.Count == 0 ? null : new GuestModel(result.Rows[0]);
        }

        public bool Insert(GuestModel entity)
        {
            string query = "INSERT INTO Guests (Name) VALUES (@Name)";
            SqlParameter[] parameters = { new SqlParameter("@Name", entity.Name) };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public int? InsertAndReturnId(GuestModel entity)
        {
            string query = "INSERT INTO Guests (Name) VALUES (@Name); SELECT SCOPE_IDENTITY()";
            SqlParameter[] parameters = { new SqlParameter("@Name", entity.Name) };
            DataTable result = _dbContext.ExecuteQuery(query, parameters);
            // return null if no rows were affected
            return result.Rows.Count == 0 ? null : Convert.ToInt32(result.Rows[0][0]);
        }

        public bool Update(GuestModel entity)
        {
            string query = "UPDATE Guests SET Name = @Name WHERE ID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", entity.Name),
                new SqlParameter("@ID", entity.Id)
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
