

using System;
using System.Collections.Generic;

namespace ChatRoomApp
{


 public class Program
    {
        public static void Main(String[] args)
        {
                 
            
            
Console.WriteLine("Welcome to ChatApp!");
 {
            var roomManager = new ChatRoomManager();

            var room1 = new ChatRoom();
            var room2 = new ChatRoom();

            roomManager.AddRoom(room1);
            roomManager.AddRoom(room2);

            var user1 = new ChatUser("Shane");
            var user2 = new ChatUser("Victor");

            user1.EnterRoom(room1);
            user2.EnterRoom(room1);

            user1.SendChatMessage("Hello, everyone!");
            user2.SendChatMessage("Hi, Shane!");

            var user3 = new ChatUser("Charlie");
            user3.EnterRoom(room2);

            user1.SendChatMessage("Goodbye, Victor!");

            Console.WriteLine("Users in Room 1:");
            foreach (var user in room1.GetListOfUsers())
            {
                Console.WriteLine(user.Username);
              
            }

            Console.WriteLine("Messages in Room 1:");
            room1.DisplayMessages();

            Console.ReadLine();
            

            



          
        }
            
        }




        }

}
