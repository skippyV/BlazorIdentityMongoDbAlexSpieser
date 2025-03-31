using AspNetCore.Identity.MongoDbCore.Models;
using MongoDB.Bson;
using MongoDbGenericRepository.Attributes;

namespace BlazorIdentityMongoDbAlexSpieser.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    [CollectionName("Users")]
    public class ApplicationUser : MongoIdentityUser<ObjectId>
    {
        public ApplicationUser() : base()
        {
        }
        public ApplicationUser(string userName, string email) : base(userName, email)
        {
        }
        //public int Age { get; set; } = -1;
    }

}
