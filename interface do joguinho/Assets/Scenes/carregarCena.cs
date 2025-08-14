using UnityEngine;
using UnityEngine.SceneManagement;

public class carregarCena : MonoBehaviour
{
    public string nomeDaCena;

    public void Carregar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}

