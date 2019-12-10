using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpCoin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(1 * Time.deltaTime, 1));
        gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 255 * 0.1f * Time.deltaTime);
        
    }
}
