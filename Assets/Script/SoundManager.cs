using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip Audio1; 
    public AudioClip Audio2; 
    public string groundTag = "Ground"; 
    public string ringTag = "Ring"; 
    
    
  
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag(groundTag))
        {
            PlaySound(Audio1); 
        }
        if(collision.gameObject.CompareTag(ringTag))
        {
            PlaySound(Audio2); 
        }
    }

    
    private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}