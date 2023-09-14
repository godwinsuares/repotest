// program to create a ChatRoom


using System;

namespace MediatorPattern

{
    class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine("{0} : {1} ", user.GetName(), message);
        }

        // add a user to the chatroom
        public static void AddUser(User user)
        {
            Console.WriteLine("User {0} has joined the chatroom", user.GetName());
            Console.WriteLine();
            Console.WriteLine();
        
        
    }