using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouDoNote.Controllers;
using YouDoNote.DAO;
using YouDoNote.Data;
using YouDoNote.Models;
using YouDoNote.Services;


namespace YouDoNote.Forms
{
    public partial class UpdateForm : Form
    {
        private readonly NoteController _noteController;
        public event Action<NoteItem> NoteUpdated;
        private NoteItem _note;
        public UpdateForm(NoteItem noteItem)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NoteRepository(context);
            var noteService = new NoteService(noteRepository);
            _noteController = new NoteController(noteService);

            _note = noteItem;
            PopulateFormFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string noteTitle = txtTitle.Text;
            string noteContent = rtxtContent.Text;

            _note.NoteTitle = noteTitle;
            _note.NoteContent = noteContent;
            _note.Date = DateTime.Now;

            NoteUpdated?.Invoke(_note);
            this.Close();
        }

        private void PopulateFormFields()
        {
            txtTitle.Text = _note.NoteTitle;
            rtxtContent.Text = _note.NoteContent;
            lblDate.Text = $"Last Updated: {_note.Date:yyyy-MM-dd}";
        }

        private void gboxUpdate_Enter(object sender, EventArgs e)
        {

        }
    }
}
