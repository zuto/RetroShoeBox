using System.Collections.Generic;
using RetroShoeBox.Models;

namespace RetroShoeBox.Services
{
    public class NoteStorageService
    {
        private NoteStorageService()
        {
        }

        public static NoteStorageService Instance { get; } = new NoteStorageService();

        private List<RetroNote> ListOfNotes = new List<RetroNote>();
        public void SaveNewNote(RetroNote note)
        {
            ListOfNotes.Add(note);
        }

        public List<RetroNote> GetAllNotes()
        {
            return ListOfNotes;
        }
    }
}