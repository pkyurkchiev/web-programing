﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AM.Data.Entities
{
    public class Assignment : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime EndedOn { get; set; }
    }
}
