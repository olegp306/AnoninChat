using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Dal.Entitys
{
    public class ParticipantsChat
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
    }
}