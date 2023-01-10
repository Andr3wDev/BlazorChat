using ChatApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChatApp.Client.ChatManager
{
    public interface IChatHub
    {
        Task<List<ApplicationUser>> GetUsersAsync();
        Task SaveMessageAsync(ChatMessage message);
        Task<List<ChatMessage>> GetConversationAsync(string contactId);
        Task<ApplicationUser> GetUserDetailsAsync(string userId);
    }
}
