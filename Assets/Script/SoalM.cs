using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalM : MonoBehaviour {

    [System.Serializable]
    public class soal
    {
        [TextArea]
        [Header("soal")]

        public string inisoal;


        [Header("pilihan")]
        public string iniA;
        public string iniB, iniC, iniD;


        [Header("jawaban")]
        public bool A;
        public bool B, C, D;

    }

    Text teksoal, teksA, teksB, teksC, teksD;

    public List<soal> soalnya;
    // Use this for initialization
    void Start()
    {
        teksoal = GameObject.Find("Tsoal").GetComponent<Text>();
        teksA = GameObject.Find("A").GetComponent<Text>();
        teksB = GameObject.Find("B").GetComponent<Text>();
        teksC = GameObject.Find("C").GetComponent<Text>();
        teksD = GameObject.Find("D").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        teksoal.text = soalnya[0].inisoal;
        teksA.text = soalnya[0].iniA;
        teksB.text = soalnya[0].iniB;
        teksC.text = soalnya[0].iniC;
        teksD.text = soalnya[0].iniD;
    }
}
