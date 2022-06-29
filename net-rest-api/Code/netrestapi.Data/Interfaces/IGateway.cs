using MongoDB.Driver;

namespace netrestapi.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
