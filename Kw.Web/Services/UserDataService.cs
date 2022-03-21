using Kw.Model;
using System.Text.Json;

namespace Kw.Web.Services
{

    public interface IUserDataService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }


    public class UserDataService : IUserDataService
    {
        private readonly HttpClient _httpClient;

        public UserDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(int id) => await JsonSerializer.DeserializeAsync<User>(
                await _httpClient.GetStreamAsync($"api/values/{id}"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        public async Task<IEnumerable<User>> GetUsers() => await JsonSerializer.DeserializeAsync<IEnumerable<User>>(
                await _httpClient.GetStreamAsync($"api/values"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
