using Models;
using ModelViews;
using NUnit.Framework;

namespace Tests.ModelView
{
    [TestFixture]
    public class PlayerViewModel_Tests
    {
        [Test]
        public void GET_PlayerCharacter()
        {
            Character playerCharacter = MainViewModel.PlayerViewModel.PlayerCharacter;
            
            Assert.Null(playerCharacter);
        }
        
        [Test]
        public void INVOKE_NewPlayerCharacter()
        {
            MainViewModel.PlayerViewModel.PlayerCharacter = CharacterFactory.Normal("Test");
            Character playerCharacter = MainViewModel.PlayerViewModel.PlayerCharacter;
            
            Assert.NotNull(playerCharacter);
        }
    }
}
