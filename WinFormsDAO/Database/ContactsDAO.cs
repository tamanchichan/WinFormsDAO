using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDAO.Class;

namespace WinFormsDAO.Database
{
    public class ContactsDAO
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=True;Database=Contacts;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";
        public List<Contact> Contacts {  get; set; } = new List<Contact>();
    }
}
