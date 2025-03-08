using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using static CreatorKitCode.StatSystem;

public class weapon_custom : Weapon.WeaponAttackEffect
{
     
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attackData.AddDamage(DamageType.Fire, 3);
        
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        data.GetDamage(DamageType.Fire);
    }
}
