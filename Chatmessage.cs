using System;
using System.Collections.Generic;

namespace ChatRoomApp
// namespace ChatRoom

{

    
    public class ChatMessage
    {
        public DateTime SentTime{ get; }
        public string 	Message{ get; }
        public string Username{ get; }

        public ChatMessage(DateTime sentTime, string message, string username)
        {
            SentTime = sentTime;
            Message = message;
            Username = username;
        }

        public string GetMessage()
        {
            return Message;
        }
        public DateTime GetTime()
        {
        return SentTime;
        }
        
        
        




    }

}


