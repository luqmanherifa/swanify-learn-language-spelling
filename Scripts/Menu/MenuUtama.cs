using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtama : MonoBehaviour
{
    //Tombol Menu Utama
    public void MenuMulai()
    {
        StartCoroutine(MenuMulaiWaktu());
    }

        IEnumerator MenuMulaiWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuMulai");
        }

    public void MenuInfo()
    {
        StartCoroutine(MenuInfoWaktu());
    }

        IEnumerator MenuInfoWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("MenuInfo");
        }

    public void MenuKeluar()
    {
        StartCoroutine(MenuKeluarWaktu());
    }

        IEnumerator MenuKeluarWaktu()
        {
            yield return new WaitForSeconds(0.3f);
            Debug.Log("Anda telah keluar dari aplikasi.");
            Application.Quit();
        }

    //Animasi Tombol Menu Utama
    public void AnimationMenuMulai()
    {
        GetComponent<Animation>().Play("ButtonMenuMulai");
    }

    public void AnimationMenuInfo()
    {
        GetComponent<Animation>().Play("ButtonMenuInfo");
    }

    public void AnimationMenuKeluar()
    {
        GetComponent<Animation>().Play("ButtonMenuKeluar");
    }
}