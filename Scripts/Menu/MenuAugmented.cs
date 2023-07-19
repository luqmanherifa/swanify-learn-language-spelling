using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAugmented : MonoBehaviour
{
    public void AugmentedTeks01()
    {
        StartCoroutine(AugmentedTeks01Waktu());
    }

        IEnumerator AugmentedTeks01Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("AugmentedTeks01");
        }

    public void AugmentedTeks02()
    {
        StartCoroutine(AugmentedTeks02Waktu());
    }

        IEnumerator AugmentedTeks02Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("AugmentedTeks02");
        }

    public void AugmentedTeks03()
    {
        StartCoroutine(AugmentedTeks03Waktu());
    }

        IEnumerator AugmentedTeks03Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("AugmentedTeks03");
        }

    public void KembaliMulai()
    {
        StartCoroutine(KembaliMulaiWaktu());
    }

        IEnumerator KembaliMulaiWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuMulai");
        }

    //Animasi Tombol Menu Augmented
    public void AnimationAugmentedTeks01()
    {
        GetComponent<Animation>().Play("ButtonAugmentedTeks01");
    }

    public void AnimationAugmentedTeks02()
    {
        GetComponent<Animation>().Play("ButtonAugmentedTeks02");
    }

    public void AnimationAugmentedTeks03()
    {
        GetComponent<Animation>().Play("ButtonAugmentedTeks03");
    }

    //Animasi Tombol Kembali
    public void AnimationKembali()
    {
        GetComponent<Animation>().Play("ButtonKembali");
    }
}