using Neowire.Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Neowire.Test
{
    public class Data
    {
        [Fact]
        void TestRepository_Builds()
        {
            var repository = TestRepositoryBuilder.BuildStandardTestRepository();
        }
    }
}
