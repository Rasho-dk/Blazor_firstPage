using Blazor_firstPage.Shared;
using Blazor_firstPage.Server.MockData;

namespace Blazor_firstPage.Server.Service.UserService
{
    public class UserService
    {
        public List<User> Users { get; set; }

        public UserService() 
        {
            //Users = MockUser.GetMockUser();    
            Users  = SQL_User.GetUsers();   
            
        }
        public List<User> GetUsers()
        {
            return Users;
        }
        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void DeleteUser(int id)
        {
            Users.Remove(Users.Find(u => u.Id == id));
        }   
    }
}
