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
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT COUNT(*) FROM Accounts WHERE Username=@user AND Password=@pass";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            return (int)cmd.ExecuteScalar() > 0;
        }

        // Lấy thông tin account (vàng, nâng cấp)
        public static void LoadAccountData(string username)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT Gold, UpgradeHP, UpgradeDamage FROM Accounts WHERE Username=@user";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user", username);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                AccountData.Gold = reader.GetInt32(0);
                AccountData.UpgradeHP = reader.GetInt32(1);
                AccountData.UpgradeDamage = reader.GetInt32(2);
            }
        }

        // Thêm account mới
        public static bool RegisterAccount(string username, string password)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Kiểm tra trùng user
            string checkSql = "SELECT COUNT(*) FROM Accounts WHERE Username=@user";
            using SqlCommand checkCmd = new SqlCommand(checkSql, conn);
            checkCmd.Parameters.AddWithValue("@user", username);
            if ((int)checkCmd.ExecuteScalar() > 0) return false;

            // Insert mới với vàng = 0, nâng cấp = 0
            string sql = "INSERT INTO Accounts (Username, Password, Gold, UpgradeHP, UpgradeDamage) " +
                         "VALUES (@user, @pass, 0, 0, 0)";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.ExecuteNonQuery();
            return true;
        }

        // Cập nhật vàng/nâng cấp
        public static void UpdateAccountData()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "UPDATE Accounts SET Gold=@gold, UpgradeHP=@hp, UpgradeDamage=@damage " +
                         "WHERE Username=@user";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@gold", AccountData.Gold);
            cmd.Parameters.AddWithValue("@hp", AccountData.UpgradeHP);
            cmd.Parameters.AddWithValue("@damage", AccountData.UpgradeDamage);
            cmd.Parameters.AddWithValue("@user", AccountData.Username);
            cmd.ExecuteNonQuery();
        }
    }
}
