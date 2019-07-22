using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp11Project
{
    public delegate void EventJournal<TJournalEntry>(TJournalEntry journalEntry);
    
}
