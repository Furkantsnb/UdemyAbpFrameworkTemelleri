using Volo.Abp.Modularity;

namespace DenemeApp;

public abstract class DenemeAppApplicationTestBase<TStartupModule> : DenemeAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
