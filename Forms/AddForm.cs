using YouDoNote.Controllers;
using YouDoNote.DAO;
using YouDoNote.Data;
using YouDoNote.Services;

namespace YouDoNote.Forms
{
    public partial class AddForm : Form
    {
        private readonly NoteController _noteController;
        public event Action NoteAdded;
        public AddForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NoteRepository(context);
            var noteService = new NoteService(noteRepository);
            _noteController = new NoteController(noteService);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noteTitle = txtTitle.Text;
            string noteContent = rtxtContent.Text;

            DateTime currentDate = DateTime.Now.Date;

            _noteController.AddNote(noteTitle, noteContent);
            MessageBox.Show($"Added Successfully!\nDate: {currentDate:yyyy-MM-dd}", "Information");

            //Raise the event to notify the Main Form
            NoteAdded?.Invoke();
            this.Close();
        }
    }
}
