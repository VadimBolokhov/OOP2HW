using System;
using UnityEngine;

namespace Homework.Movement
{
    public abstract class Move
    {
        protected MonoBehaviour Owner;
        public Action OnMovementDirectionChanged;

        protected Move(MonoBehaviour owner)
        {
            Owner = owner;
        }

        public abstract void Execute();
    }
}