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
    private AudioSource[] waterSteps;
    private AudioSource[] groundSteps;
    private AudioSource[] grassSteps;
    private AudioSource[] sandSteps;
    private AudioSource coins;

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

    public void PlayAudio(Audios audio)
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
