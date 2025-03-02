using System;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using BKS;

namespace BKS
{
    public partial class Form1 : MaterialForm
    {
        string connectionString = ConnectionStringEncryptor.Decrypt("AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAqTLx46JSM06f8HpEmdM0xQQAAAACAAAAAAAQZgAAAAEAACAAAACYt1bY0gAJ+aTFJ/Ox4BV7sHbD+daAHz+g7F9GfNO1WgAAAAAOgAAAAAIAACAAAAA/mU+QgLMEnWYLHVSyBg727XvMr1iFPkcY2v97M0cAVZAAAAChBA8MNA3tL1rDIP4+qM0nC0NCIpokAK5HmigYbGr/1H2fOrq/5/tQA5Ibe8yuhzKuFHmIQHIFR8eKuGh8NQBczrJ8iKqe42dzTzJLwSGvTcAqBQfDtkBHaRPSgGts4vr5MG895aU9AEfuGxmVM/FSnWBjfE0eLHrl80WP3Ui38qP1uM5zYXxmxyi/jRSjvAlAAAAABeDyaGXu4ThIz7IckEtpZ/Q8mBu0hrr43zJGONFnFoZkBeQ4kDzm8Z8P2FgnowgYt1f0bTHSE03Z5gr0Z1Af7A==");
        private LoginHistoryService loginHistoryService;

        public Form1()
        {
            InitializeComponent();
            loginHistoryService = new LoginHistoryService(connectionString);

            // Material Skin theme ayarlarý
            var manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string username = userName.Text.Trim();
            if (!string.IsNullOrEmpty(username))
            {
                // Son giriþ bilgisini yükle
                materialLabel3.Text = "Son Giriþ Zamaný: " + System.DateTime.Now.ToString();
            }
        }

        private void bttnLgn_Click(object sender, EventArgs e)
        {
            // Kullanýcý adý ve þifre giriþleri
            string username = userName.Text.Trim();
            string password = passWord.Text.Trim();

            // SQL sorgusu
          
            string sorgu = "Select count(*) from BKSUsers where Username=@Username and Password=@Password and anaokuluid is not null";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand datecom = new SqlCommand(sorgu, connection))
                    {
                        datecom.Parameters.AddWithValue("@username", username);
                        datecom.Parameters.AddWithValue("@password", password);

                        using (SqlCommand command = new SqlCommand(sorgu, connection))
                        {
                          
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            // Sonucu kontrol et
                            int userCount = (int)command.ExecuteScalar();
                            if (userCount > 0)
                            {
                                MessageBox.Show("Giriþ baþarýlý!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form2 form2 = new Form2();
                                form2.FormClosed += (s, args) => Application.Exit();  // Form2 kapanýnca Form1'i kapat
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Tüm programý kapatýr.
        }

        public class LoginHistoryService
        {
            private readonly string _connectionString;

            public LoginHistoryService(string connectionString)
            {
                _connectionString = connectionString;
            }

            //public string GetLastLoginTime(string username)
            //{
            //    string lastLoginTime = "Bilinmiyor";
            //    string query = "SELECT Songiriszamani FROM Bksusers WHERE Username=@Username";

            //    using (SqlConnection connection = new SqlConnection(_connectionString))
            //    {
            //        try
            //        {
            //            connection.Open();
            //            using (SqlCommand command = new SqlCommand(query, connection))
            //            {
            //                command.Parameters.AddWithValue("@Username", username);
            //                object result = command.ExecuteScalar();
            //                if (result != null)
            //                {
            //                    lastLoginTime = result.ToString();
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Hata: " + ex.Message);
            //        }
            //    }

            //    return lastLoginTime;
            }
        }
    }

