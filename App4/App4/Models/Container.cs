using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App4.Models
{
    class Container
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public double Mass { get; set; }
    }
}
