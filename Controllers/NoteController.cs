using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouDoNote.Models;
using YouDoNote.Services;

namespace YouDoNote.Controllers
{
    public class NoteController
    {
        private readonly NoteService _noteService;

        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }

        public List<NoteItem> GetAllNotes()
        {
            return _noteService.GetAllNote();
        }

        public NoteItem GetNoteById(int id)
        {
            return _noteService.GetNoteById(id);
        }

        public void AddNote(string noteTitle, string noteContent)
        {
            var noteItem = new NoteItem
            {
                NoteTitle = noteTitle,
                NoteContent = noteContent,
                Date = DateTime.Now,
            };
            _noteService.AddNote(noteItem);
        }

        public void UpdateNote(int id, string noteTitle, string noteContent)
        {
            var noteItem = _noteService.GetNoteById(id);
            if (noteItem != null)
            {
                noteItem.NoteTitle = noteTitle;
                noteItem.NoteContent = noteContent;
                noteItem.Date = DateTime.Now;
                _noteService.UpdateNote(noteItem);
            }
        }

        public void DeleteNote(int id)
        {
            _noteService.DeleteNote(id);
        }
    }
}
