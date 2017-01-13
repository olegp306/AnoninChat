using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Dal
{
    public class DBManager : IDBManager
    {
        public IEnumerable<Chat> GetAllChatsByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetAllMessagesByChatId(Guid chatId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatParticipant> GetAllParticipantsChatByChatId(Guid chatId)
        {
            throw new NotImplementedException();
        }

        public Message SetMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public ChatParticipant SetParticipantsChat(ChatParticipant participantsChat)
        {
            throw new NotImplementedException();
        }
    }
}