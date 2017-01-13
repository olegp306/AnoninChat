using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Dal
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid ChatId { get; set; }
        public DateTime SendDateTime { get; set; }
        public string Content { get; set; }
    }
}