using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            AudioManager.Instance.PlayAudio(Audios.coins);
            Destroy(gameObject);
        }
    }
}
