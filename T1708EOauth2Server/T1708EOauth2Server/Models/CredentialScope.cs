﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T1708EOauth2Server.Models
{
    public class CredentialScope
    {
        public CredentialScope()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.DeletedAt = DateTime.Now;
            this.Status = 1;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int Status { get; set; }
    }
}
