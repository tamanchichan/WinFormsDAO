using Microsoft.Data.SqlClient;
using WinFormsDAO.Class;

namespace WinFormsDAO.Database
{
    public class ContactsDAO
    {
        public string connectionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=True;Database=Contacts;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";

        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void LoadContacts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, first_name, last_name, email, phone_number FROM Contact";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contact contact = new Contact()
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                                LastName = reader.GetString(reader.GetOrdinal("last_name")),
                                Email = reader.GetString(reader.GetOrdinal("email")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("phone_number"))
                            };

                            Contacts.Add(contact);
                        }
                    }
                }
            }
        }
    }
}
