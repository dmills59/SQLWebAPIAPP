﻿using System.Collections.Generic;
namespace ToDoListDataAPI.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public List<KeyValuePair<string, string>> DBchanges { get; set; }
    }
}