using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInfo : MonoBehaviour
{
    public void InfoAplikasi()
    {
        StartCoroutine(InfoAplikasiWaktu());
    }

    IEnumerator InfoAplikasiWaktu()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("InfoTentangAplikasi");
    }

    public void InfoPengembang()
    {
        StartCoroutine(InfoPengembangWaktu());
    }

        IEnumerator InfoPengembangWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("InfoTentangPengembang");
        }

    public void InfoPenggunaan()
    {
        StartCoroutine(InfoPenggunaanWaktu());
    }

        IEnumerator InfoPenggunaanWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("InfoCaraPenggunaan");
        }

    //Animasi Tombol Menu Mulai
    public void AnimationInfoAplikasi()
    {
        GetComponent<Animation>().Play("ButtonInfoAplikasi");
    }

    public void AnimationInfoPengembang()
    {
        GetComponent<Animation>().Play("ButtonInfoPengembang");
    }

    public void AnimationInfoPenggunaan()
    {
        GetComponent<Animation>().Play("ButtonInfoPenggunaan");
    }

    public void KembaliMenuUtama()
    {
        StartCoroutine(KembaliMenuUtamaWaktu());
    }

        IEnumerator KembaliMenuUtamaWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuUtama");
        }

    public void KembaliMenuInfo()
    {
        StartCoroutine(KembaliMenuInfoWaktu());
    }

        IEnumerator KembaliMenuInfoWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuInfo");
        }

    //Animasi Tombol Kembali
    public void AnimationKembali()
    {
        GetComponent<Animation>().Play("ButtonKembali");
    }
}