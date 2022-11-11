using ModelViews;
using NUnit.Framework;

namespace Tests.ModelView
{
    [TestFixture]
    public class MainViewModel_Tests
    {
        [Test]
        public void GET_PlayerModelView()
        {
            PlayerViewModel viewModel = MainViewModel.PlayerViewModel;
            
            Assert.NotNull(viewModel);
        }
        
        [Test]
        public void GET_SceneModelView()
        {
            SceneViewModel viewModel = MainViewModel.SceneViewModel;
            
            Assert.NotNull(viewModel);
        }
        
        [Test]
        public void GET_LocalizationModelView()
        {
            LocalizationViewModel viewModel = MainViewModel.LocalizationViewModel;
            
            Assert.NotNull(viewModel);
        }
    }
}
