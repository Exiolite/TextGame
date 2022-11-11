using System;
using Models;

namespace ModelViews
{
    public sealed class SceneModelView
    {
        public Scene Scene { get; private set; }


        public void SetScene(Scene scene)
        {
            Scene = scene;
        }
        
        
        public void Display()
        {
            if (Scene == null)
                ModelView.LocalizationModelView.DisplayMessage("Scene.Null");
            else
                Console.WriteLine($"{Scene}");
        }
    }
}