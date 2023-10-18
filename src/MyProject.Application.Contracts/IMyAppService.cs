using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MyProject;

public interface IMyAppService : IApplicationService
{
    Task SlowRunningTaskAsync();
}