using Xunit;

namespace DenemeApp.EntityFrameworkCore;

[CollectionDefinition(DenemeAppTestConsts.CollectionDefinitionName)]
public class DenemeAppEntityFrameworkCoreCollection : ICollectionFixture<DenemeAppEntityFrameworkCoreFixture>
{

}
