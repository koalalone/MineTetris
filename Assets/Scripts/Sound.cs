using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource clearLine;
    public AudioSource rotation;
    public AudioSource hardDrop;
    public AudioSource blockStep;

    public void PlayClearLine()
    {
        clearLine.Play();
    }
    public void PlayRotation()
    {
        rotation.Play();
    }
    public void PlayHardDrop()
    {
        hardDrop.Play();
    }
    public void PlayBlockStep()
    {
        blockStep.Play();
    }
}
