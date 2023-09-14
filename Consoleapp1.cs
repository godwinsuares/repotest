// Application to create a chat room and add users to it.
// 
// ChatRoom class
// 
// namespace ChatRoomApp
// 
// 
// 
// 
// 
// {
//  public class ChatRoom 
// {
//         private List<ChatUser> _users;
//         private List<ChatMessage> _messages;
// 
//         public ChatRoom()
//         {
//             _users = new List<ChatUser>();
//             _messages = new List<ChatMessage>();
//         }
// 
//         public void UserEnteredRoom(ChatUser user)
//         {
//             _users.Add(user);
//         }
// 
//         public void UserLeftRoom(ChatUser user)
//         {
//             _users.Remove(user);
//         }
// 
//         public IReadOnlyList<ChatUser> GetListOfUsers()
//         {
//             return _users;
//         }
// 
//         public void AddMessage(ChatMessage message)
//         {
//             _messages.Add(message);
//         }
// 
//         public void DisplayMessages()
//         {
//             foreach (var message in _messages)
//             {
//                 Console.WriteLine($"[{message.GetTime()}] {message.Username}: {message.GetMessage()}");
//             }
//         }
//     }
// }
// 
// Compare this snippet from Tideman.cs:
// write a class for ChatUser to enter room and send chat messages
// 
// namespace ChatRoomApp
// {
// 
// 
//     public class ChatUser    {
//         public string Username { get; }
//         private ChatRoom _currentRoom;
//         public ChatRoom CurrentRoom { get => _currentRoom; set => _currentRoom = value; }
//         public List<ChatMessage> Messages { get; }
//         public ChatUser(string username)
//         {
//             Username = username;
//             Messages = new List<ChatMessage>();
//         }
// 
//         public void SendMessage(string message)
//         {
//             Messages.Add(new ChatMessage(Username, message));
//         }
// 
//         public void SendMessage(ChatMessage message)
//         {
//             Messages.Add(message);
// 
//     
//     public void DisplayMessages()
//         {
//             foreach (var message in _messages)
//             {
//                 Console.WriteLine($"[{message.GetTime()}] {message.Username}: {message.GetMessage()}");
//             }
//         }
//     }
// 
// Compare this snippet from ChatRoom.cs:
// using System;
// using System.Collections.Generic;
// 
// program code to create a chat room and add users to it.
// 
// ChatRoom class
// 
// namespace ChatRoomApp
// 
// 
// 
// 
// 
// 
// 
// Compare this snippet from Chatmessage.cs:
// using System;
// using System.Collections.Generic;
// 
// namespace ChatRoomApp
// namespace ChatRoom
// 
// {
// 
//     
//     public class ChatMessage