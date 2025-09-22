using System.Data.SqlClient;

namespace Kien
{
    public static class Database
    {
        private static string connectionString =
            "Server=DESKTOP-8OVL8E7;Database=UserDB;Trusted_Connection=True;";

        // Kiểm tra login
        public static bool CheckLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Accounts WHERE Username = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Thêm account mới
        public static bool RegisterAccount(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra trùng user
                string checkSql = "SELECT COUNT(*) FROM Accounts WHERE Username = @user";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@user", username);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0) return false;

                // Insert
                string sql = "INSERT INTO Accounts (Username, Password) VALUES (@user, @pass)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }
}
