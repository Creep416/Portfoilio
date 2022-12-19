using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class NoteBase
    {
        private string title;
        private string text;
        private bool completed;
        public NoteBase(string ttl, string txt)
        {
            title = ttl;
            text = txt;
            completed = false;
        }
        public string Title() { return title; }
        public string Text() { return text; }
    }
}
