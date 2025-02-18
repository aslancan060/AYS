using System.Data.SqlClient;

namespace BKS
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=31.186.11.161;Database=asl2e6ancomtr_PaymentDBDB;User Id = asl2e6ancomtr_aslan; Password=Aslan123.@;TrustServerCertificate=True;";
        private LoginHistoryService loginHistoryService;
        public Form1()
        {
            InitializeComponent();
            loginHistoryService = new LoginHistoryService(connectionString);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string username = userName.Text.Trim();
            if (!string.IsNullOrEmpty(username))
            {
                label3.Text = "Son Giriþ Zamaný: " + loginHistoryService.GetLastLoginTime(username);
            }
        }
        private void bttnLgn_Click(object sender, EventArgs e)
        {
            // Kullanýcý adý ve þifre giriþleri
            string username = userName.Text.Trim();
            string password = passWord.Text.Trim();

            // Veritabaný baðlantý dizesi
            string connectionString = "Server=31.186.11.161;Database=asl2e6ancomtr_PaymentDBDB;User Id = asl2e6ancomtr_aslan; Password=Aslan123.@;TrustServerCertificate=True;";

            // SQL sorgusu
            string query = "exec ValidateAndUpdateLogin  @Username, @Password";
            string sorgu = "Select * from Bksusers where Username=@Username and Password=@Password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand datecom = new SqlCommand(sorgu, connection))
                    {
                        datecom.Parameters.AddWithValue("@username", username);
                        datecom.Parameters.AddWithValue("@password", password);
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader sqlDataReader = datecom.ExecuteReader())
                            {

                                if (sqlDataReader.Read())
                                {

                                    label3.Text = "Son Giriþ Zamaný: " + sqlDataReader["Songiriszamani"].ToString();

                                }
                            }
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            // Sonucu kontrol et
                            int userCount = (int)command.ExecuteScalar();
                            if (userCount > 0)
                            {
                                MessageBox.Show("Giriþ baþarýlý!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form2 form2 = new Form2();

                                this.Hide();
                                form2.Show();


                            }
                            else
                            {
                                MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public class LoginHistoryService
        {
            private readonly string _connectionString;

            public LoginHistoryService(string connectionString)
            {
                _connectionString = connectionString;
            }

            public string GetLastLoginTime(string username)
            {
                string lastLoginTime = "Bilinmiyor";

                string query = "SELECT Songiriszamani FROM Bksusers WHERE Username=@Username";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                lastLoginTime = result.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }

                return lastLoginTime;
            }
        }

    }
  
}
