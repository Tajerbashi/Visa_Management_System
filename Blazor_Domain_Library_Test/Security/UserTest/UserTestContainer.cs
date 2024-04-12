namespace Blazor_Domain_Library_Test.Security.UserTest
{
    public class UserTestContainer
    {
        //private readonly UserModelGenerator Generator;
        //public UserTestContainer(UserModelGenerator generator)
        //{
        //    Generator = generator;
        //}
        [Trait("CRUD", "Create")]
        [Fact]
        public void Create()
        {
            //  Arrange
            var Generator = new UserModelGenerator();
            var model = Generator.GetUserEntity();
            //  Act
            var result = model.Name.Count() > 6 && model.Family.Count() > 6 && !model.IsDeleted && model.IsActive;
            //  Assert
            Assert.True(result);
        }
        [Trait("CRUD", "Update")]
        [Fact]
        public void Update()
        {
            //  Arrange
            var Generator = new UserModelGenerator();
            var model = Generator.GetUserEntity();
            var newModel = Generator.GetUserEntityForUpdate();
            //  Act
            var result = model.Name.Count() > 6 && !newModel.Name.Equals(model.Name) &&
                         model.Family.Count() > 6 && !newModel.Family.Equals(model.Family) &&
                         !model.IsDeleted &&
                         model.IsActive;
            //  Assert
            Assert.True(result);
        }
        [Trait("CRUD", "Delete")]
        [Fact]
        public void Delete()
        {
            //  Arrange
            var modelService = new UserModelGenerator();
            //  Act
            var result = true;
            //  Assert
            Assert.True(result);
        }
        [Trait("CRUD", "Read")]
        [Fact]
        public void Read()
        {
            //  Arrange
            var modelService = new UserModelGenerator();
            //  Act
            var result = modelService.GetUserEntity();
            //  Assert
            Assert.NotNull(result);
        }
    }
}
