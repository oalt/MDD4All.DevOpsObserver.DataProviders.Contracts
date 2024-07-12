using MDD4All.DevOpsObserver.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MDD4All.DevOpsObserver.DataProviders.Contracts
{
    public interface IDevOpsStatusProvider
    {
        Task<List<DevOpsStatusInformation>> GetDevOpsStatusListAsync(DevOpsSystem devOpsSystem);
    }
}
