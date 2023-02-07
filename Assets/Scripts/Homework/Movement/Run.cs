using UnityEngine;

namespace Homework.Movement
{
    /**
     * TODO:
     * 1. Реализовать этот тип перемещения по аналогии с Walk, но отличающийся от него,
     * например, пусть перемещение будет по окружности заданного радиуса.
     * 2. Заменить передвижение у HappyDog и/или SadDog этим типом. Убедиться, что он работает.
     */
    public class Run : Move
    {
        private readonly Vector3 _center;
        private readonly float _radius;
        private readonly float _speed;
        private float _angle;
        
        public Run(MonoBehaviour owner) : base(owner)
        {
        }

        public Run(MonoBehaviour owner, Vector3 center, float radius, float speed) : base(owner)
        {
            _center = center;
            _radius = radius;
            _speed = speed;
        }

        public override void Execute()
        {
            var newPosition = Owner.transform.position;

            _angle += _speed * Time.deltaTime;
            newPosition.x = _radius * Mathf.Sin(_angle);
            newPosition.y = _radius * Mathf.Cos(_angle);

            Owner.transform.position = _center + newPosition;
        }
    }
}