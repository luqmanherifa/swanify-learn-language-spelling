using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMateri : MonoBehaviour
{
    //Tombol Materi Huruf
    public void MateriHurufKapital()
    {
        StartCoroutine(MateriHurufKapitalWaktu());
    }

        IEnumerator MateriHurufKapitalWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriHurufKapital");
        }

    public void MateriHurufMiring()
    {
        StartCoroutine(MateriHurufMiringWaktu());
    }

        IEnumerator MateriHurufMiringWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriHurufMiring");
        }

    public void MateriHurufTebal()
    {
        StartCoroutine(MateriHurufTebalWaktu());
    }

        IEnumerator MateriHurufTebalWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriHurufTebal");
        }

    //Tombol Materi Kata
    public void MateriKataDepan()
    {
        StartCoroutine(MateriKataDepanWaktu());
    }

        IEnumerator MateriKataDepanWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriKataDepan");
        }

    public void MateriKataPartikel()
    {
        StartCoroutine(MateriKataPartikelWaktu());
    }

        IEnumerator MateriKataPartikelWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriKataPartikel");
        }

    public void MateriKataGanti()
    {
        StartCoroutine(MateriKataGantiWaktu());
    }

        IEnumerator MateriKataGantiWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriKataGanti");
        }

    //Tombol Materi Tanda Baca
    public void MateriTandaTitik()
    {
        StartCoroutine(MateriTandaTitikWaktu());
    }

        IEnumerator MateriTandaTitikWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriTandaTitik");
        }

    public void MateriTandaKoma()
    {
        StartCoroutine(MateriTandaKomaWaktu());
    }

        IEnumerator MateriTandaKomaWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriTandaKoma");
        }

    public void MateriTandaHubung()
    {
        StartCoroutine(MateriTandaHubungWaktu());
    }

        IEnumerator MateriTandaHubungWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MateriTandaHubung");
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

    //Animasi Tombol Menu Materi
    public void AnimationMateriHurufKapital()
    {
        GetComponent<Animation>().Play("ButtonMateriHurufKapital");
    }

    public void AnimationMateriHurufMiring()
    {
        GetComponent<Animation>().Play("ButtonMateriHurufMiring");
    }

    public void AnimationMateriHurufTebal()
    {
        GetComponent<Animation>().Play("ButtonMateriHurufTebal");
    }

    public void AnimationMateriKataDepan()
    {
        GetComponent<Animation>().Play("ButtonMateriKataDepan");
    }

    public void AnimationMateriKataPartikel()
    {
        GetComponent<Animation>().Play("ButtonMateriKataPartikel");
    }

    public void AnimationMateriKataGanti()
    {
        GetComponent<Animation>().Play("ButtonMateriKataGanti");
    }

    public void AnimationMateriTandaTitik()
    {
        GetComponent<Animation>().Play("ButtonMateriTandaTitik");
    }

    public void AnimationMateriTandaKoma()
    {
        GetComponent<Animation>().Play("ButtonMateriTandaKoma");
    }

    public void AnimationMateriTandaHubung()
    {
        GetComponent<Animation>().Play("ButtonMateriTandaHubung");
    }

    //Animasi Tombol Kembali
    public void AnimationKembali()
    {
        GetComponent<Animation>().Play("ButtonKembali");
    }
}