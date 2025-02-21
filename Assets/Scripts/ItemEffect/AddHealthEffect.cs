using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int healthVary;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(healthVary);
        return true;
    }
}

