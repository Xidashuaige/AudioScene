using UnityEngine;

public enum Audios
{
    waterSteps,
    grassSteps,
    sandSteps,
    groundSteps,
    coins
}

public class AudioManager : MonoBehaviour
{
    static private AudioSource[] waterSteps;
    static private AudioSource[] groundSteps;
    static private AudioSource[] grassSteps;
    static private AudioSource[] sandSteps;
    private static readonly AudioSource coins;

    // Start is called before the first frame update
    void Start()
    {
        waterSteps = GameObject.Find("WalkInWater").GetComponents<AudioSource>();
        groundSteps =  GameObject.Find("WalkInGrass").GetComponents<AudioSource>();
        grassSteps =  GameObject.Find("WalkInGround").GetComponents<AudioSource>();
        sandSteps =  GameObject.Find("WalkInSand").GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static public void PlayAudio(Audios audio)
    {
        switch (audio)
        {
            case Audios.waterSteps:
                break;
            case Audios.grassSteps:
                break;
            case Audios.groundSteps:
                break;
            case Audios.sandSteps:
                break;
            case Audios.coins:
                coins.Play();
                break;
            default:
                break;
        }
    }
}
