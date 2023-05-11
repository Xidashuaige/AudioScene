using UnityEngine;
using UnityEngine.Audio;

public enum Audios
{
    // waterSteps,
    // grassSteps,
    // sandSteps,
    // groundSteps,
    coins
}

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;
    // static private AudioSource[] waterSteps;
    // static private AudioSource[] groundSteps;
    // static private AudioSource[] grassSteps;
    // static private AudioSource[] sandSteps;
    private AudioSource _coins;
    public AudioMixerSnapshot GameSnap;
    public AudioMixerSnapshot menuSnap;

    public static AudioManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<AudioManager>();

                if (!_instance)
                {
                    GameObject singletonObject = new GameObject("AudioManager");
                    _instance = singletonObject.AddComponent<AudioManager>();
                    DontDestroyOnLoad(singletonObject);
                }
            }
            return _instance;
        }
    }
  
    // Start is called before the first frame update
    void Start()
    {
        // waterSteps = GameObject.Find("WalkInWater").GetComponents<AudioSource>();
        // groundSteps = GameObject.Find("WalkInGrass").GetComponents<AudioSource>();
        // grassSteps = GameObject.Find("WalkInGround").GetComponents<AudioSource>();
        // sandSteps = GameObject.Find("WalkInSand").GetComponents<AudioSource>();
        _coins = GameObject.Find("Coins").GetComponent<AudioSource>();
    }
  
    public void PlayAudio(Audios audio)
    {
        switch (audio)
        {
            // case Audios.waterSteps:
            //     break;
            // case Audios.grassSteps:
            //     break;
            // case Audios.groundSteps:
            //     break;
            // case Audios.sandSteps:
            //     break;
            case Audios.coins:
                _coins.Play();
                break;
            default:
                break;
        }
    }

    public void OpenMenu()
    {
        menuSnap.TransitionTo(0.2f);
    }

    public void CloseMenu()
    {
        GameSnap.TransitionTo(0.2f);
    }
}
