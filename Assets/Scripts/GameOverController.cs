using UnityEngine;
using UnityEngine.UI; // Asegúrate de agregar esta línea
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI ScoreText; // Esta variable se utiliza para asignar el objeto de texto en el Inspector

    void Start()
    {
        // Obtener el puntaje del PlayerController
        int puntaje = FindObjectOfType<PlayerController>().score;

        // Actualizar el texto del objeto de texto
        ScoreText.text = puntaje.ToString();
    }

    public void RestartGame()
    {
        // Reiniciar el puntaje
        FindObjectOfType<PlayerController>().score = 0;

        SceneManager.LoadScene("SampleScene");
    }
}
