using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="UPGRADES/Element")]
public class Upgrades : ScriptableObject
{
    public string elementName; // 요소명
    public Sprite elementImage; // 요소 이미지
    public float elementCost; // 요소 가격
    public float elementSkill; // 능력치
    public string elementDesc; // 요소 설명

}
