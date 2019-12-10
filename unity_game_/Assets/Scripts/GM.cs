using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Mathf;

public class GM : MonoBehaviour
{
    [SerializeField]
    private Text coinText;

    public float coinCount;

    [SerializeField]
    private GameObject coin;

    public float speed;

    public float clickCoin;

    public GameObject coinUP;
    public Text coinUPText;

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
        clickCoin = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        coinCount += Time.deltaTime * speed;
        coinText.text = coinCount.ToString("N1");

    }

    public void OnClickCoin()
    {
        coinCount += clickCoin;

        float r = 150f;
        float degree = Random.Range(0, 180);

        GameObject upcoin = Instantiate(coinUP, new Vector3(coin.gameObject.transform.position.x + r * Cos(degree), coin.gameObject.transform.position.y + r * Sin(degree)), Quaternion.identity);
        upcoin.transform.SetParent(GameObject.Find("Canvas").transform);

        coinUPText = upcoin.transform.GetChild(0).GetComponent<Text>();
        coinUPText.text = "+" + clickCoin.ToString("N1");
        Destroy(upcoin, 5f);
    }


}
