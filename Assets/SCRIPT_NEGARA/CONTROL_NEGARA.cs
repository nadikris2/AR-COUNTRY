using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CONTROL_NEGARA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Buat kelas pindah scene
    public void pindah_scene(string nama_scene)
    {
        SceneManager.LoadScene(nama_scene);
    }
}
