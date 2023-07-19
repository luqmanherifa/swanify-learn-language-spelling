using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMulai : MonoBehaviour
{
    //Tombol Menu Mulai
    public void MenuMateri()
    {
        StartCoroutine(MenuMateriWaktu());
    }

        IEnumerator MenuMateriWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuMateri");
        }

    public void MenuKuis()
    {
        StartCoroutine(MenuKuisWaktu());
    }

        IEnumerator MenuKuisWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuKuis");
        }

    public void MenuAugmented()
    {
        StartCoroutine(MenuAugmentedWaktu());
    }

        IEnumerator MenuAugmentedWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuAugmented");
        }

    public void KembaliMenu()
    {
        StartCoroutine(KembaliMenuWaktu());
    }

        IEnumerator KembaliMenuWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuUtama");
        }

    //Animasi Tombol Menu Mulai
    public void AnimationMenuMateri()
    {
        GetComponent<Animation>().Play("ButtonMenuMateri");
    }

    public void AnimationMenuKuis()
    {
        GetComponent<Animation>().Play("ButtonMenuKuis");
    }

    public void AnimationMenuAugmented()
    {
        GetComponent<Animation>().Play("ButtonMenuAugmented");
    }

    public void AnimationKembali()
    {
        GetComponent<Animation>().Play("ButtonKembali");
    }
}