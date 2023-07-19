using UnityEngine;

public class GroundTile : MonoBehaviour
{

    // public int counter = 0;

    GroundSpawn groundSpawn;


    // Start is called before the first frame update
    void Start()
    {
        groundSpawn = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnTree();
        SpawnTrunk();
        SpawnLeftRocks();
        SpawnRightRocks();
        SpawnLeftBillboardRocks();
        SpawnRightBillboardRocks();
        
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
    public GameObject trunkPrefab;
    void SpawnTrunk(){

        int index = Random.Range(22, 30);
        Transform spawnPoint = transform.GetChild(index).transform;

        Instantiate(trunkPrefab, spawnPoint.position, Quaternion.identity, transform);

    }

    public GameObject rockPrefab;

    void SpawnLeftRocks(){

        Transform spawnPointRock = transform.GetChild(18).transform;

        Instantiate(rockPrefab, spawnPointRock.position, Quaternion.identity, transform);

    }

    void SpawnRightRocks(){

        Transform spawnPointRock = transform.GetChild(19).transform;

        Instantiate(rockPrefab, spawnPointRock.position, Quaternion.identity, transform);

    }

    public GameObject rockPrefab2;

    void SpawnLeftBillboardRocks(){
            Transform spawnPointRock = transform.GetChild(20).transform;

        Instantiate(rockPrefab2, spawnPointRock.position, Quaternion.identity, transform);
    }

    void SpawnRightBillboardRocks(){
        Transform spawnPointRock = transform.GetChild(21).transform;

        Instantiate(rockPrefab2, spawnPointRock.position, Quaternion.identity, transform);
    }



}
