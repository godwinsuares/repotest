using System;
using System.Collections.Generic;

// program code to create a chat room and add users to it.

// ChatRoom class

namespace ChatRoomApp





{
 public class ChatRoom 
{
        private List<ChatUser> _users;
        private List<ChatMessage> _messages;

        public ChatRoom()
        {
            _users = new List<ChatUser>();
            _messages = new List<ChatMessage>();
        }

        public void UserEnteredRoom(ChatUser user)
        {
            _users.Add(user);
        }

        public void UserLeftRoom(ChatUser user)
        {
            _users.Remove(user);
        }

        public IReadOnlyList<ChatUser> GetListOfUsers()
        {
            return _users;
        }

        public void AddMessage(ChatMessage message)
        {
            _messages.Add(message);
        }

        public void DisplayMessages()
        {
            foreach (var message in _messages)
            {
                Console.WriteLine($"[{message.GetTime()}] {message.Username}: {message.GetMessage()}");
            }
        }
    }
}
