using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting;

public class ItemEffect : UsableItem.UsageEffect
{
    public int heatlhRestore = 2;
    public override bool Use(CharacterData user){
        if(user==null) return false;
        user.Stats.ChangeHealth(heatlhRestore);
        return true;
    }
}
