using System;
using System.CodeDom;
using System.Security.Authentication.ExtendedProtection;
using myKSU_v3;

namespace myKSU_v3.Library 
{
    public class AdvisorBot
    {
        private BotReplyManager replyManager;

        // INSTANTIATE REPLY MANAGER WITH CONSTRUCTOR
        public AdvisorBot(BotReplyManager replyManager)
        {
            this.replyManager = replyManager;
        }

        // USE REPLY MANAGER TO DEFINE INPUT & DETERMINE CORRECT REPLY
        public string Respond(string userQuery)
        {
            if (string.IsNullOrWhiteSpace(userQuery))
                return "I'm sorry, I didn't understand. Can you try a different keyword or clarify your question?";

            userQuery = userQuery.ToLower(); // Normalize input for case-insensitive matching

            // Route query to appropriate reply method
            string? response = replyManager.DefineReply(userQuery);

            return response ?? "Hoot! Sorry, I couldn't find an answer for that. Try asking about university offices, your student info, or study tips!";
        }        
        
    }
}
