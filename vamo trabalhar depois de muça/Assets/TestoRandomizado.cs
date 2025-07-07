using TMPro;
using UnityEngine;

public class TextoRandomizado : MonoBehaviour
{
    public int numero;
    public string novoTexto;
    public TextMeshProUGUI UITexto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && numero > 0)
        {
            numero--;
            UITexto.text = novoTexto + " " + numero;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            numero++;
            UITexto.text = novoTexto + " " + numero;
        }
    }
}





















