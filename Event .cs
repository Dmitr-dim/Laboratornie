using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

public class Event
{
    public DateTime Date { get; set; }
    public string Description { get; set; }

    public Event(DateTime date, string description)
    {
        Date = date;
        Description = description;
    }
}