using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ability/Damage", order = 20)]
public class DamgeAbility : ScriptableAbility
{
    public override void Cast(Entity target)
    {
        base.Cast(target);
    }
}
