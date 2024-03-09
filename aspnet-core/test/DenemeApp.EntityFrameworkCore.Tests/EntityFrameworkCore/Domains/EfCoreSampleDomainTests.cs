using DenemeApp.Samples;
using Xunit;

namespace DenemeApp.EntityFrameworkCore.Domains;

[Collection(DenemeAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DenemeAppEntityFrameworkCoreTestModule>
{

}
