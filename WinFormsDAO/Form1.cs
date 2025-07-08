using WinFormsDAO.Database;

namespace WinFormsDAO
{
    public partial class Form1 : Form
    {
        private ContactsDAO contactsDAO = new ContactsDAO();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                contactsDAO.LoadContacts();
                dataGridView1.DataSource = contactsDAO.Contacts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contacts: {ex.Message}");
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
    }
}
