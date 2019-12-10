using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private GameObject toolTip; // 툴팁창 이미지
    [SerializeField]
    private Text toolTipTextUI; // 툴팁 설명 UI
    private string toolTipText; // 툴팁에 들어갈 글

    
    // Start is called before the first frame update
    void Start()
    {
        toolTip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        toolTip.SetActive(true);
        toolTip.transform.position = new Vector2(gameObject.transform.position.x - 150f, gameObject.transform.position.y - 150f);
        toolTipText = "" + GetComponent<Element>().upgrade.elementDesc;

        NewLineReplace(toolTipText);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTip.SetActive(false);
    }

    private string NewLineReplace (string _elementDesc)
    {
        //if(_elementDesc.IndexOf("")) // >> 아래꺼 쓰려면 조건 넣어줘야할듯

        //int index = _elementDesc.IndexOf("\\n");
        //_elementDesc = _elementDesc.Remove(index, 2);
        //_elementDesc = _elementDesc.Insert(index, "\n");

        _elementDesc = _elementDesc.Replace("\\n", "\n");
        toolTipTextUI.text = _elementDesc;

        return _elementDesc;
    }
   
}
