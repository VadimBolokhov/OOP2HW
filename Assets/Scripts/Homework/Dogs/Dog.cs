using Homework.Common;
using Homework.Movement;
using UnityEngine;

namespace Homework.Dogs
{
    /**
     * TODO:
     * 1. Добавить всем собакам способность гавкать: достаточно метода, пишущего в Unity-консоль строку с сообщение.
     * 2. HappyDog должен гавкать более радостно.
     * 3. (сложно) Пусть собаки гавкают только тогда, когда меняют направление движения.
     */
    public abstract class Dog : MonoBehaviour, IColorChangeable, IBarkable
    {
        public abstract void ChangeColor();

        public abstract void Bark();
        
        protected Move Move;

        private SpriteRenderer _spriteRenderer;

        protected void Start()
        {
            Move = ProvideMovementBehaviour();

            InputController.Instance.OnColorChanged += OnColorChanged;
        }

        protected void Update()
        {
            Move.Execute();
        }

        private void OnDestroy()
        {
            InputController.Instance.OnColorChanged -= OnColorChanged;
        }

        private void OnColorChanged()
        {
            ChangeColor();
        }

        protected SpriteRenderer GetSpriteRenderer()
        {
            if (_spriteRenderer == null)
                _spriteRenderer = GetComponentInChildren<SpriteRenderer>();

            return _spriteRenderer;
        }

        protected virtual Move ProvideMovementBehaviour()
        {
            var movementBehaviour = new Walk(this, -4, 4, 1);
            movementBehaviour.OnMovementDirectionChanged += OnMovementDirectionChanged;
            return movementBehaviour;
        }

        private void OnMovementDirectionChanged()
        {
            Bark();
        }
    }
}