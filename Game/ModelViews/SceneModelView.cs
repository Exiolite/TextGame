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
        
        public void DisplayScene()
        {
            if (Scene == null)
            {
                Console.WriteLine("No one there...");
                return;
            }
            if (Scene.PlayerCharacter == null) return;
            if (Scene.Enemies == null) return;
            if (Scene.Enemies.Count == 0) return;
            
            Scene.PlayerCharacter.Display();
            
            foreach (Character character in Scene.Enemies)
            {
                character.Display();
            }
        }
    }
}