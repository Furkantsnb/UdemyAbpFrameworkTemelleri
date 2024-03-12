using Volo.Abp.Modularity;

namespace DenemeModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class DenemeModuleDomainTestBase<TStartupModule> : DenemeModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
