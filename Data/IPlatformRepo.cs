using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        //When implemented, this method will return all Platform records from the database.
        IEnumerable<Platform> GetAllPlatforms();

        Platform? GetPlatformById(int id);

        void CreatePlatform(Platform plat);
    }
    
}