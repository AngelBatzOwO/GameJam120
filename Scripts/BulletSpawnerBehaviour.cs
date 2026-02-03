using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BulletSpawnerBehaviour : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    [SerializeField] float nextFire;
   
    [SerializeField]
    List<GameObject> pooledBullets = new List<GameObject>();


    private void Awake()
    {

        nextFire = Random.Range(1, 3);
        InvokeRepeating("SpawnBullet", 2f, nextFire);
    }



    void SpawnBullet()
    {

        Vector3 _bulletSpawnPoint = transform.position;
        for (int i = 0; i < pooledBullets.Count; i++)
        {
            if (!pooledBullets[i].activeInHierarchy)
            {
                pooledBullets[i].transform.position = _bulletSpawnPoint;
                pooledBullets[i].transform.rotation = transform.rotation;
                pooledBullets[i].GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                pooledBullets[i].SetActive(true);
                return;
            }
        }

        //GameObject _bullet = Instantiate(bulletPrefab, bulletSpawnPoint, transform.rotation);
        //_bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * speed;
        //pooledBullets.Add(_bullet);

        var bullet = Instantiate(bulletPrefab, _bulletSpawnPoint, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        pooledBullets.Add(bullet);
    }
}
