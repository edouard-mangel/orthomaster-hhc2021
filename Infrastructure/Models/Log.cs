using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class Log
    {
        public long Id { get; set; }
        public string Text { get; set; }
    }
}
