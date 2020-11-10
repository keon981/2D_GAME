using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public Text textCount;
    public int count;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "門")
        {
            final.SetActive(true);
        }

        if (collision.tag == "吃貨")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "鑽石數量:" + count;
        }
      
        if (collision.tag == "毒品")
        {
            Destroy(gameObject);
        }

    }

}
