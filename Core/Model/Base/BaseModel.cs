using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SignalR.core.Model.Base
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDelete { get; set; }
    }
}
