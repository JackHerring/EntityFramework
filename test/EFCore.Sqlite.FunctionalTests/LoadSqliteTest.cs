// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore
{
    public class LoadSqliteTest : LoadTestBase<LoadSqliteTest.LoadSqliteFixture>
    {
        public LoadSqliteTest(LoadSqliteFixture fixture)
            : base(fixture)
        {
        }

        public class LoadSqliteFixture : LoadFixtureBase
        {
            protected override ITestStoreFactory<TestStore> TestStoreFactory => SqliteTestStoreFactory.Instance;
            
            protected override DbContextOptionsBuilder AddOptions(DbContextOptionsBuilder builder)
                => base.AddOptions(builder).ConfigureWarnings(c => c
                    .Log(RelationalEventId.QueryClientEvaluationWarning));
        }
    }
}
