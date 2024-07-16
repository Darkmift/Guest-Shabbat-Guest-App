using Guest_Shabbat_Guest_App.DAL.Models;
using System.Data;
using System.Data.SqlClient;

namespace Guest_Shabbat_Guest_App.DAL.Repositories
{
    internal class FoodRepository : IRepository<FoodModel>
    {
        private readonly DBContext _dbContext;

        public FoodRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM Food WHERE ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }


        public List<FoodModel> FindAll()
        {
            List<FoodModel> foods = new();
            string query = "SELECT ID, Name, Guest_ID, Category_ID FROM Food";
            DataTable result = _dbContext.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                foods.Add(new FoodModel(row));
            }
            return foods;
        }

        public List<FoodModel> FindAllJoinedWithGuests(int categoryId)
        {
            List<FoodModel> foods = new();
            string query = @"SELECT f.ID, f.Name, f.Guest_ID, f.Category_ID, g.Name AS GuestName
                                FROM Food f
                                JOIN Guests g 
                                ON f.Guest_ID = g.ID 
                                WHERE f.Category_ID = @CategoryID";
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            DataTable result = _dbContext.ExecuteQuery(query, parameters);
            foreach (DataRow row in result.Rows)
            {
                foods.Add(new FoodModel(row));
            }
            return foods;
        }

        public FoodModel? FindById(int id)
        {
            string query = "SELECT ID, Name, Guest_ID, Category_ID FROM Food WHERE ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            DataTable result = _dbContext.ExecuteQuery(query, parameters);

            return result.Rows.Count == 0 ? null : new FoodModel(result.Rows[0]);
        }

        public bool Insert(FoodModel entity)
        {
            string query = "INSERT INTO Food (Name, Guest_ID, Category_ID) VALUES (@Name, @Guest_ID, @Category_ID)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", entity.Name),
                new SqlParameter("@Guest_ID", entity.Guest_ID),
                new SqlParameter("@Category_ID", entity.Category_ID)
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public int InsertAndReturnId(FoodModel entity)
        {
            string query = "INSERT INTO Food (Name, Guest_ID, Category_ID) VALUES (@Name, @Guest_ID, @Category_ID); SELECT SCOPE_IDENTITY()";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", entity.Name),
                new SqlParameter("@Guest_ID", entity.Guest_ID),
                new SqlParameter("@Category_ID", entity.Category_ID)
            };
            return (int)_dbContext.ExecuteScalar(query, parameters);
        }

        public bool Update(FoodModel entity)
        {
            string query = "UPDATE Food SET Name = @Name, Guest_ID = @Guest_ID, Category_ID = @Category_ID WHERE ID = @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", entity.Name),
                new SqlParameter("@Guest_ID", entity.Guest_ID),
                new SqlParameter("@Category_ID", entity.Category_ID),
                new SqlParameter("@ID", entity.ID)
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
