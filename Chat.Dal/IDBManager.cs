using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Dal
{
    interface IDBManager
    {
        IEnumerable<Chat> GetAllChatsByUserId(Guid userId);

        IEnumerable<Message> GetAllMessagesByChatId(Guid chatId);
        Message SetMessage(Message message);

        IEnumerable<ChatParticipant> GetAllParticipantsChatByChatId(Guid chatId);
        ChatParticipant SetParticipantsChat(ChatParticipant participantsChat);
    }
}
