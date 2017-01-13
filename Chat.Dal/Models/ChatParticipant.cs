using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Dal

{
    public class ChatParticipant
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
    }
}