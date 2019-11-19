using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [SerializeField]
    private Text coinText;

    public float coinCount;

    [SerializeField]
    private GameObject coin;

    public float speed;

    public static GM instance = null;              

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        coinCount = 0f;
        speed = 1.0f;
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
