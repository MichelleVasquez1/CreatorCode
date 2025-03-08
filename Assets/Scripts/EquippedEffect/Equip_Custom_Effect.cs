using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Equip_Custom_Effect : EquipmentItem.EquippedEffect
{
     private int mod = 2;
     public override void Equipped(CharacterData user)
     {
          user.Stats.Strength +=(mod);
     }
     public override void Removed(CharacterData user)
     {
           user.Stats.Strength -=(mod);
     }
}