using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting;

public class ItemEffect : UsableItem.UsageEffect
{
    Item Item_add;
    public override bool Use(CharacterData user)
    {
        user.Inventory.AddItem(Item_add);
        return true;
    }
}
