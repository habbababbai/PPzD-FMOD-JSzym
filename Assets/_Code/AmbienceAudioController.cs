using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class AmbienceAudioController : MonoBehaviour
{
    [SerializeField] private GameObject outsideAudio;
    [SerializeField] private GameObject insideAudo;
    private bool isPlayerInside = false;

    private void Start()
    {
        outsideAudio.SetActive(true);
        insideAudo.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInside = !isPlayerInside;
            Debug.Log($"Player inside: {isPlayerInside}");
            if (isPlayerInside)
            {
                insideAudo.SetActive(true);
                outsideAudio.SetActive(false);
            }
            else
            {
                insideAudo.SetActive(false);
                outsideAudio.SetActive(true);
            }
        }
    }
}
