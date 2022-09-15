using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ammo;
    public ParticleSystem shootSmoke;
    public bool ready = true;
    public float shootDelayTime = 3f;
    [SerializeField]private GameObject humanLoader;
    [SerializeField]private Animator loadingAnimation;
    void Awake()
    {
        humanLoader = GameObject.Find("HumanLoader");
        humanLoader.gameObject.SetActive(false);
        loadingAnimation = humanLoader.GetComponent<Animator>();
    }

    void Update()
    {
        if(Time.timeScale >= 1)
        {
            if (Input.GetKeyDown(KeyCode.Space) && ready == true)
            {
                ShootTheAmmo();
                AudioManager.instance.shootAudio.Play();
            }   
}
    }
    public void ShootTheAmmo()
    {
        ParticleSystem playSystem = Instantiate(shootSmoke, transform.position, transform.rotation);
        GameObject currentAmmo = Instantiate(ammo, transform.position, transform.rotation);

        ready = false;
        humanLoader.SetActive(true);
        loadingAnimation.SetTrigger("needToReload");
        

        Destroy(playSystem, 0.5f);
        Destroy(currentAmmo, 3f);

        StartCoroutine(nameof(ShootDelay));
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(shootDelayTime);
        humanLoader.SetActive(false);
        ready = true;
    }
}
