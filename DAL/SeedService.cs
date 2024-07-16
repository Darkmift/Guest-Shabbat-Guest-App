using System.Data;

namespace Guest_Shabbat_Guest_App.DAL
{
    internal class SeedService
    {
        private DBContext _dbContext;
        private string DBName;
        public SeedService(DBContext dBContext, string dBName)
        {
            _dbContext = dBContext;
            DBName = dBName;
        }

        public void EnsureTablesAndSeedData()
        {
            string sqlScript = @$"USE {DBName};

                      BEGIN TRANSACTION;

                      BEGIN TRY

                          IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Guests' AND type = 'U')
                          BEGIN
                              CREATE TABLE Guests
                              (
                                  ID INT PRIMARY KEY IDENTITY,
                                  Name NVARCHAR(20) UNIQUE
                              );

                              -- Insert sample data into Guests
                              INSERT INTO Guests (Name) VALUES
                              (N'אברהם'),
                              (N'יצחק'),
                              (N'יעקב');
                          END

                          IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Categories' AND type = 'U')
                          BEGIN
                              CREATE TABLE Categories
                              (
                                  ID INT PRIMARY KEY IDENTITY,
                                  Name NVARCHAR(20) UNIQUE
                              );

                              -- Insert sample data into Categories
                              INSERT INTO Categories (Name) VALUES
                              (N'בשר'),
                              (N'דגים'),
                              (N'שתייה'),
                              (N'סלטים');
                          END

                          IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Food' AND type = 'U')
                          BEGIN
                              CREATE TABLE Food
                              (
                                  ID INT PRIMARY KEY IDENTITY,
                                  Guest_ID INT,
                                  Category_ID INT,
                                  Name NVARCHAR(20),
                                  CONSTRAINT FK_Food_Guests FOREIGN KEY (Guest_ID) REFERENCES Guests(ID),
                                  CONSTRAINT FK_Food_Categories FOREIGN KEY (Category_ID) REFERENCES Categories(ID),
                                  CONSTRAINT UQ_Food UNIQUE (Guest_ID, Category_ID, Name) -- Unique constraint
                              );

                              -- Insert sample data into Food
                              INSERT INTO Food (Guest_ID, Category_ID, Name) VALUES
                              (1, 1, N'סטייק'),
                              (1, 2, N'סלמון'),
                              (3, 3, N'בירה'),
                              (2, 1, N'קציצות');
                          END

                          COMMIT TRANSACTION;
                      END TRY
                      BEGIN CATCH
                          ROLLBACK TRANSACTION;
                          THROW; -- Re-throw the caught exception to be handled by the calling method
                      END CATCH";

            _dbContext.ExecuteNonQuery(sqlScript, null);
            CheckTablesCreated(); // A method to check that tables were created and are accessible
        }

        private DataTable CheckTablesCreated()
        {
            string sqlScript = @"
                                SELECT 'Categories' AS tname, COUNT(*) AS count FROM Categories
                                UNION ALL
                                SELECT 'Guests', COUNT(*) FROM Guests
                                UNION ALL
                                SELECT 'Food', COUNT(*) FROM Food;";

            DataTable result = _dbContext.ExecuteQuery(sqlScript, null);
            if (result.Rows.Count != 3)
                throw new Exception("One or more tables are missing or inaccessible.");

            return result;
        }

    }
}
