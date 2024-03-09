using Volo.Abp.Modularity;

namespace DenemeApp;

/* Inherit from this class for your domain layer tests. */
public abstract class DenemeAppDomainTestBase<TStartupModule> : DenemeAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
