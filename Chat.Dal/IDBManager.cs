using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Dal
{
    interface IDBManager
    {

        IEnumerable<Chat> GetAllChatsByUserId(string userId);

        IEnumerable<Message> GetAllMessagesByChatId(Guid? chatId);

        IEnumerable<ParticipantsChat> GetAllParticipantsChatByChatId(Guid? chatId);

        ChatInstance SetChat(ChatInstance chat);

        Message SetMessage(Message message);

        ParticipantsChat SetParticipantsChat(ParticipantsChat participantsChat);
    }
}
