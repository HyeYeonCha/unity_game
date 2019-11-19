using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Skill/skill")]
public class Skill : ScriptableObject
{
    public string skillName; // skill name
    public float skillAmount; // skill
    public Sprite skillImageSprite; // skill Image
    public string skillDesc; // skill description
}
