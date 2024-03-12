using Volo.Abp.Modularity;

namespace DenemeModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class DenemeModuleApplicationTestBase<TStartupModule> : DenemeModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
