using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class EquipItem : EquipmentItem.EquippedEffect
{
     private int mod = 3;
     public override void Equipped(CharacterData user)
     {
          user.Stats.AddTimedModifierStrength+=(mod);
     }
     
     public override void Removed(CharacterData user)
     {
     
     }
}
