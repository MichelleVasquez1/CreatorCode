using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Custom_Effect : UsableItem.UsageEffect
{
    public int heatlhRestore = 2;
    public override bool Use(CharacterData user){
        if(user==null) return false;
        user.Stats.ChangeHealth(heatlhRestore);
        return true;
    }
}