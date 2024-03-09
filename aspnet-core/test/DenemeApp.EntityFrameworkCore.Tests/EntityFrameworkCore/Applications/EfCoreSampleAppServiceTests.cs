using DenemeApp.Samples;
using Xunit;

namespace DenemeApp.EntityFrameworkCore.Applications;

[Collection(DenemeAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DenemeAppEntityFrameworkCoreTestModule>
{

}
