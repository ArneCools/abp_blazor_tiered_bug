using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MyProject;

public class MyAppService : ApplicationService, IMyAppService
{
    public async Task SlowRunningTaskAsync()
    {
        await Task.Delay(5000);
    }
}