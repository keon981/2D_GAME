using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("星之匙");
        final.SetActive(true);
    }

}
