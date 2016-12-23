using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Dal.Entitys
{
    public class Message
    {
        public Guid Id { get; set; }
        public DateTime SendDateTime { get; set; }
        public Guid ChatId { get; set; }
        public string Content { get; set; }

        public bool IsRemoved { get; set; }
        public bool IsEdited { get; set; }


    }
}