using System;
using Models;

namespace ModelViews
{
    public sealed class SceneViewModel
    {
        public Scene Scene { get; set; } = Scene.GetTestScene();


        public void Display()
        {
            if (Scene == null)
                MainViewModel.LocalizationViewModel.DisplayMessage("Scene.Null");
            else
                Console.WriteLine($"{Scene}");
        }
    }
}
