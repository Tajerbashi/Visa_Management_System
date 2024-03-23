using Blazor_Domain_Library_Test.Security.FixtureClasses;
using Blazor_Domain_Library_Test.Security.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Blazor_Domain_Library_Test.Security
{
    public class UserTests : IClassFixture<UserFixture>
    {
        private readonly ITestOutputHelper console;
        private readonly UserFixture userFixture;
        private CalculatorService calculatorService;

        public UserTests(
            ITestOutputHelper testOutputHelper,
            UserFixture userFixture
            )
        {
            console = testOutputHelper;
            this.userFixture = userFixture;
            calculatorService = userFixture.calculatorService;
        }

        [Fact]
        public void CheckData()
        {
            console.WriteLine("Test Started");
            //  Arrange 
            int a = 10;
            int b = 20;
            //  Act
            int res = calculatorService.Sum(a,b);
            //  Assert
            Assert.Equal(30, res);
            console.WriteLine("Test Finished");
        }
    }
}
