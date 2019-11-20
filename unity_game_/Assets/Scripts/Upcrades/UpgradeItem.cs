using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Text itemTextUI;
    private string itemText;

    [SerializeField]
    private Image itemImage;

    float nextCoin;

    private Element element;

    int level;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        element = FindObjectOfType<Element>();
        itemText = element.upgrade.elementName;
        level = 1;
        itemTextUI.text = itemText + level;
        itemImage.sprite = element.upgrade.elementImage;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nextCoin = GM.instance.coinCount - element.upgrade.elementCost;
        if (nextCoin >= 0)
        {
            GetComponent<Image>().color = new Color32(255, 239, 162, 255);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (GM.instance.coinCount - element.upgrade.elementCost <= 0)
        {
            return;
        }
        else
        {
            level++;
            audio.Play();

            GM.instance.coinCount = nextCoin;
            itemTextUI.text = itemText + level;

            SkillBar.instance.speed += element.upgrade.elementSkill;
            SkillBar.instance.barTextUI.text = "1 product per " + SkillBar.instance.speed + " second";

            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

}
