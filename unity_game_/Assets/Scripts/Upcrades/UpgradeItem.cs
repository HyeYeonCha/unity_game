using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Text itemTextUI;
    public string itemText;

    [SerializeField]
    private Image itemImage;

    float nextCoin;
    
    int level;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        itemText = GetComponent<Element>().upgrade.elementName;
        level = 1;
        itemTextUI.text = itemText + level;
        itemImage.sprite = GetComponent<Element>().upgrade.elementImage;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nextCoin = GM.instance.coinCount - GetComponent<Element>().upgrade.elementCost;
        if (nextCoin >= 0)
        {
            GetComponent<Image>().color = new Color32(255, 239, 162, 255);
        } else
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (GM.instance.coinCount - GetComponent<Element>().upgrade.elementCost <= 0)
        {
            return;
        }
        else
        {
            level++;
            audio.Play();

            GM.instance.coinCount = nextCoin;
            itemTextUI.text = itemText + level;

            if(gameObject.tag == "Speed")
            {
                SkillBar.instance.speed += GetComponent<Element>().upgrade.elementSkill;

                SkillBar.instance.barTextUI.text = "1 product per " + (2 - SkillBar.instance.speed).ToString("N1") + " second";
            } else if (gameObject.tag == "Quantity")
            {
                GM.instance.speed += GetComponent<Element>().upgrade.elementSkill;
                
            } else if (gameObject.tag == "Click")
            {
                GM.instance.clickCoin += GetComponent<Element>().upgrade.elementSkill;
            }
            

            if (2 - SkillBar.instance.speed < 0.01f)
            {
                SkillBar.instance.speed = 1.99f;
            }

            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

}
