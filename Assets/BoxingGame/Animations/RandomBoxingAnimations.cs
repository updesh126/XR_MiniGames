using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoxingAnimations : MonoBehaviour
{
    private Animator animator;
    public string[] boxingAnimationTriggers; // Assign animation trigger names in the Inspector.

    bool isWalking;

    private void Start()
    {
        // Get the Animator component attached to the character.
        animator = GetComponent<Animator>();

        isWalking = false;
        // Start a coroutine to change animations randomly.
        StartCoroutine(ChangeBoxingAnimation());
    }

    private System.Collections.IEnumerator ChangeBoxingAnimation()
    {
        if ( isWalking == true)
        {
            animator.CrossFade("Walking", 2f);
        }
        while (isWalking == false)
        {
            // Wait for a random interval before changing animations.
            float randomInterval = Random.Range(2f, 5f);
            yield return new WaitForSeconds(randomInterval);

            // Randomly select an animation trigger from the array.
            string randomTrigger = GetRandomBoxingTrigger();

            // Trigger the selected animation.
            animator.CrossFade(randomTrigger,2f);
        }
    }
    public void Iswalking(bool iswalk)
    {
        isWalking = iswalk;
    }
    private string GetRandomBoxingTrigger()
    {
        // Randomly select an animation trigger from the array.
        int randomIndex = Random.Range(0, boxingAnimationTriggers.Length);
        return boxingAnimationTriggers[randomIndex];
    }
}
