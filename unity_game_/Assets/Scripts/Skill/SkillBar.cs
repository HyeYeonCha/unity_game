using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBar : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Image barImage; // filledAmount
    
    public Text barTextUI; // bar description UI

    public string barText; // bar description text

    [SerializeField]
    private Image skillImage; // bar side skill image

    Info info;

    public static SkillBar instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        info = FindObjectOfType<Info>();

        skillImage.sprite = info.skill.skillImageSprite;
        speed = info.skill.skillAmount;

        barText = info.skill.skillDesc;
        barTextUI.text = barText;
    }

    // Update is called once per frame
    void Update()
    {
        BarComplate();
    }

    private void BarComplate()
    {
        barImage.fillAmount -= Time.deltaTime * speed;
        

        if(barImage.fillAmount <= 0)
        {
            barImage.fillAmount = 1f;
            GM.instance.coinCount += 10;
        }
    }

}
