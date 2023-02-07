using Homework.Movement;
using UnityEngine;

namespace Homework.Dogs
{
    /**
     * TODO:
     * 1. Реализовать этот тип по аналогии с HappyDog.
     * 2. Грустная собака должна перекрашиваться в оттенки синего.
     * 3. (сложно) Перенести метод GetSpriteRenderer в более подходящее место.
     */
    public class SadDog : Dog
    {
        public override void ChangeColor()
        {
            var random = new System.Random();
            var blue = (float)random.NextDouble();
            GetSpriteRenderer().color = new Color(0.1f, 0.1f, 0.5f + blue / 2);
        }

        public override void Bark()
        {
            Debug.Log("Sad bark");
        }

        protected override Move ProvideMovementBehaviour()
        {
            return new Run(this, new Vector3(0, 0, 0), 2f, 2f);
        }
    }
}