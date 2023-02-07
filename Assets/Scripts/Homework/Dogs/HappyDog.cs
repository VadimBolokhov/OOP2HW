using Homework.Movement;
using UnityEngine;

namespace Homework.Dogs
{
    public class HappyDog : Dog
    {
        public HappyDog()
        {
            Debug.Log("Spawning a happy dog :P");
            Move = new Walk(this, -4, 4, 11);
        }

        public override void ChangeColor()
        {
            var random = new System.Random();
            var red = (float)random.NextDouble();
            GetSpriteRenderer().color = new Color(0.5f + red / 2, 0.1f, 0.1f);
        }

        public override void Bark()
        {
            Debug.Log("Happy bark");
        }
    }
}