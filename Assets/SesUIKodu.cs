using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SesUIKodu : MonoBehaviour
{
    public AudioSource sesKaynakBileþeni;
    public AudioSource müzikKaynakBileþeni;


    public AudioClip notaDo;
    public AudioClip notaRe;
    public AudioClip notaMi;
    public AudioClip notaFa;
    public AudioClip notaSol;
    public AudioClip notaLa;
    public AudioClip notaSi;
    public AudioClip notaKalýnDo;

    public Text sarkiIsmi;
    void Start()
    {
        sesKaynakBileþeni=GetComponent<AudioSource>();
    }
    #region Notalar
    public void DoCal()
    {
        sesKaynakBileþeni.clip = notaDo;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "Do";
    }
    public void ReCal()
    {
        sesKaynakBileþeni.clip = notaRe;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "RE";
    }
    public void MiCal()
    {
        sesKaynakBileþeni.clip = notaMi;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "MÝ";
    }
    public void FaCal()
    {
        sesKaynakBileþeni.clip = notaFa;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "FA";
    }
    public void SolCal()
    {
        sesKaynakBileþeni.clip = notaSol;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "SOL";
    }
    public void LaCal()
    {
        sesKaynakBileþeni.clip = notaLa;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "LA";
    }
    public void SiCal()
    {
        sesKaynakBileþeni.clip = notaSi;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "SÝ";
    }
    public void KalýnDoCal()
    {
        sesKaynakBileþeni.clip = notaKalýnDo;
        sesKaynakBileþeni.Play();
        sarkiIsmi.text = "Kalýn DO";
    }
    #endregion

    #region Müzik Komutlarý
    public void SesArttýrma()
    {
        if(sesKaynakBileþeni.volume <= 1.0f)
        {
            sesKaynakBileþeni.volume += 0.1f;
            müzikKaynakBileþeni.volume += 0.1f;

        }
        /*if (müzikKaynakBileþeni.volume <= 1.0f)
        {
            müzikKaynakBileþeni.volume += 0.1f;
        }*/

    }
    public void SesAzaltma()
    {
        if (sesKaynakBileþeni.volume >= 0f)
        {
            sesKaynakBileþeni.volume -= 0.1f;
            müzikKaynakBileþeni.volume -= 0.1f;

        }
        /*if (müzikKaynakBileþeni.volume >= 0f)
        {
            müzikKaynakBileþeni.volume -= 0.1f;
        }*/
    }
    public void MuzikAc()
    {
        müzikKaynakBileþeni.Play();
        sarkiIsmi.text = müzikKaynakBileþeni.clip.name;
    }
    public void MuzikKapat()
    {
        müzikKaynakBileþeni.Stop();
        sarkiIsmi.text = "Çalan þarký yok !";
    }

    public void SessizeAl()
    {
        müzikKaynakBileþeni.mute = true;
    }
    public void SessizdenÇýkar()
    {
        müzikKaynakBileþeni.mute = false;
    }
    #endregion

}
