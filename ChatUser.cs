using System;
using System.Collections.Generic;

//write a class for ChatUser to enter room and send chat messages
namespace ChatRoomApp
{

namespace ChatRoom


    public class ChatUser    {
        public string Username { get; }
        private ChatRoom _currentRoom;
        public ChatRoom CurrentRoom { get => _currentRoom; set => _currentRoom = value; }
        public List<ChatMessage> Messages { get; }
        public ChatUser(string username)
        {
            Username = username;
            Messages = new List<ChatMessage>();
        }

        public void SendMessage(string message)
        {
            Messages.Add(new ChatMessage(Username, message));
        }

        public void SendMessage(ChatMessage message)
        {
            Messages.Add(message);

    
    public void DisplayMessages()
        {
            foreach (var message in _messages)
            {
                Console.WriteLine($"[{message.GetTime()}] {message.Username}: {message.GetMessage()}");
            }
        }
    }
