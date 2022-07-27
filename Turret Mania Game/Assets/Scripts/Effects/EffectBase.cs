using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debugs;

namespace TurretGame
{
    public class EffectBase : MonoBehaviour
    {
        protected CharacterUnitBase _characterUnit;

        public virtual void InitializeEffect()
        {

        }

        public virtual void GetCharacterUnit(CharacterUnitBase characterUnit)
        {
            _characterUnit = characterUnit;
        }

        //Increase movement speed
        public virtual void EffectActivation()
        {
            Debug.Log("Activating Effect");
        }

        public virtual void RemoveEffect()
        {

        }

        //Activate this for more movement speed
        protected virtual void UpdateEffectStats()
        {

        }
    }
}
