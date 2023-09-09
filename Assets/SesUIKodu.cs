using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SesUIKodu : MonoBehaviour
{
    public AudioSource sesKaynakBile�eni;
    public AudioSource m�zikKaynakBile�eni;


    public AudioClip notaDo;
    public AudioClip notaRe;
    public AudioClip notaMi;
    public AudioClip notaFa;
    public AudioClip notaSol;
    public AudioClip notaLa;
    public AudioClip notaSi;
    public AudioClip notaKal�nDo;

    public Text sarkiIsmi;
    void Start()
    {
        sesKaynakBile�eni=GetComponent<AudioSource>();
    }
    #region Notalar
    public void DoCal()
    {
        sesKaynakBile�eni.clip = notaDo;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "Do";
    }
    public void ReCal()
    {
        sesKaynakBile�eni.clip = notaRe;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "RE";
    }
    public void MiCal()
    {
        sesKaynakBile�eni.clip = notaMi;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "M�";
    }
    public void FaCal()
    {
        sesKaynakBile�eni.clip = notaFa;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "FA";
    }
    public void SolCal()
    {
        sesKaynakBile�eni.clip = notaSol;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "SOL";
    }
    public void LaCal()
    {
        sesKaynakBile�eni.clip = notaLa;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "LA";
    }
    public void SiCal()
    {
        sesKaynakBile�eni.clip = notaSi;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "S�";
    }
    public void Kal�nDoCal()
    {
        sesKaynakBile�eni.clip = notaKal�nDo;
        sesKaynakBile�eni.Play();
        sarkiIsmi.text = "Kal�n DO";
    }
    #endregion

    #region M�zik Komutlar�
    public void SesArtt�rma()
    {
        if(sesKaynakBile�eni.volume <= 1.0f)
        {
            sesKaynakBile�eni.volume += 0.1f;
            m�zikKaynakBile�eni.volume += 0.1f;

        }
        /*if (m�zikKaynakBile�eni.volume <= 1.0f)
        {
            m�zikKaynakBile�eni.volume += 0.1f;
        }*/

    }
    public void SesAzaltma()
    {
        if (sesKaynakBile�eni.volume >= 0f)
        {
            sesKaynakBile�eni.volume -= 0.1f;
            m�zikKaynakBile�eni.volume -= 0.1f;

        }
        /*if (m�zikKaynakBile�eni.volume >= 0f)
        {
            m�zikKaynakBile�eni.volume -= 0.1f;
        }*/
    }
    public void MuzikAc()
    {
        m�zikKaynakBile�eni.Play();
        sarkiIsmi.text = m�zikKaynakBile�eni.clip.name;
    }
    public void MuzikKapat()
    {
        m�zikKaynakBile�eni.Stop();
        sarkiIsmi.text = "�alan �ark� yok !";
    }

    public void SessizeAl()
    {
        m�zikKaynakBile�eni.mute = true;
    }
    public void Sessizden��kar()
    {
        m�zikKaynakBile�eni.mute = false;
    }
    #endregion

}
