using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKuis : MonoBehaviour
{
    //Tombol Kuis Huruf
    public void KuisHurufKapital01()
    {
        StartCoroutine(KuisHurufKapital01Waktu());
    }

        IEnumerator KuisHurufKapital01Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisHurufKapital01");
        }

    public void KuisHurufMiring()
    {
        StartCoroutine(KuisHurufMiringWaktu());
    }

        IEnumerator KuisHurufMiringWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisHurufMiring");
        }

    public void KuisHurufTebal()
    {
        StartCoroutine(KuisHurufTebalWaktu());
    }

        IEnumerator KuisHurufTebalWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisHurufTebal");
        }

    //Tombol Kuis Kata
    public void KuisKataDepan()
    {
        StartCoroutine(KuisKataDepanWaktu());
    }

        IEnumerator KuisKataDepanWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisKataDepan");
        }

    public void KuisKataPartikel()
    {
        StartCoroutine(KuisKataPartikelWaktu());
    }

        IEnumerator KuisKataPartikelWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisKataPartikel");
        }

    public void KuisKataGanti()
    {
        StartCoroutine(KuisKataGantiWaktu());
    }

        IEnumerator KuisKataGantiWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisKataGanti");
        }

    //Tombol Kuis Tanda Baca
    public void KuisTandaTitik()
    {
        StartCoroutine(KuisTandaTitikWaktu());
    }

        IEnumerator KuisTandaTitikWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisTandaTitik");
        }

    public void KuisTandaKoma01()
    {
        StartCoroutine(KuisTandaKoma01Waktu());
    }

        IEnumerator KuisTandaKoma01Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisTandaKoma01");
        }

    public void KuisTandaHubung()
    {
        StartCoroutine(KuisTandaHubungWaktu());
    }

        IEnumerator KuisTandaHubungWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("KuisTandaHubung");
        }

    //Tombol Kembali
    public void KembaliMulai()
    {
        StartCoroutine(KembaliMulaiWaktu());
    }

        IEnumerator KembaliMulaiWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuMulai");
        }

    //Animasi Tombol Menu Kuis
    public void AnimationKuisHurufKapital()
    {
        GetComponent<Animation>().Play("ButtonKuisHurufKapital");
    }

    public void AnimationKuisHurufMiring()
    {
        GetComponent<Animation>().Play("ButtonKuisHurufMiring");
    }

    public void AnimationKuisHurufTebal()
    {
        GetComponent<Animation>().Play("ButtonKuisHurufTebal");
    }

    public void AnimationKuisKataDepan()
    {
        GetComponent<Animation>().Play("ButtonKuisKataDepan");
    }

    public void AnimationKuisKataPartikel()
    {
        GetComponent<Animation>().Play("ButtonKuisKataPartikel");
    }

    public void AnimationKuisKataGanti()
    {
        GetComponent<Animation>().Play("ButtonKuisKataGanti");
    }

    public void AnimationKuisTandaTitik()
    {
        GetComponent<Animation>().Play("ButtonKuisTandaTitik");
    }

    public void AnimationKuisTandaKoma()
    {
        GetComponent<Animation>().Play("ButtonKuisTandaKoma");
    }

    public void AnimationKuisTandaHubung()
    {
        GetComponent<Animation>().Play("ButtonKuisTandaHubung");
    }

    //Animasi Tombol Kembali
    public void AnimationKembali()
    {
        GetComponent<Animation>().Play("ButtonKembali");
    }
}