using UnityEngine;

public class GroundTile : MonoBehaviour
{

    public int counter = 0;

    GroundSpawn groundSpawn;


    // Start is called before the first frame update
    void Start()
    {
        groundSpawn = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnTree();
        
    }

    private void OnTriggerExit(Collider other){

            groundSpawn.SpawnTile();
            
            Destroy(gameObject, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject treePrefab;

    void SpawnTree(){

        int index = Random.Range(2, 18);
        Transform spawnPoint = transform.GetChild(index).transform;

        Instantiate(treePrefab, spawnPoint.position, Quaternion.identity, transform);



    }



}
