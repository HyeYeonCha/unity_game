using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBar : MonoBehaviour
{
    public float _speed;

    [SerializeField]
    private Image barImage; // filledAmount
    
    public Text barTextUI; // bar description UI

    private string _barText; // bar description text

    [SerializeField]
    private Image skillImage; // bar side skill image

    Skill _skill;

    public static SkillBar instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);
    }

    // null 값 오류 수정해야함.

    // Start is called before the first frame update
    void Start()
    {
        _skill = FindObjectOfType<Skill>();

        //skillImage.sprite = _skill.skillImageSprite;
        //_speed = _skill.skillAmount;
    }

    // Update is called once per frame
    void Update()
    {
        BarComplate();
    }

    private void BarComplate()
    {
        barImage.fillAmount -= Time.deltaTime * _speed;
        

        if(barImage.fillAmount <= 0)
        {
            barImage.fillAmount = 1f;
            GM.instance.coinCount += 10;
        }
    }

}
