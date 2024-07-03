using Getpass.Components.Data;
using Microsoft.EntityFrameworkCore;


namespace Getpass.Components.Services
{
    public class Services
    {
        AppDb DbContext = new AppDb();



        public async Task<List<DriverPool>> Getallroutes()
        {

            return await DbContext.DriverPool.AsNoTracking().ToListAsync();

        }
        public List<Tables> Getsearch(DateOnly DateOnly)
        {
            return DbContext.Tables.Where(x => x.DateOnly == DateOnly).ToList();
        }

    }
}
