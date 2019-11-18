using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [SerializeField]
    private Text coinText;
    private float coinCount;

    [SerializeField]
    private GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        coinCount += Time.deltaTime;
        coinText.text = coinCount.ToString("N0");
    }

    public void OnClickCoin()
    {
        coinCount++;
    }


}
