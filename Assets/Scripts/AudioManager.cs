using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource Scan;

    public void ScanSuccess()
    {
        Scan.Play();
    }
}
