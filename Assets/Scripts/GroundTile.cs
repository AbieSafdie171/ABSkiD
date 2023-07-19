using UnityEngine;

public class GroundTile : MonoBehaviour
{

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
        SpawnTree2();
        SpawnBranch();
        SpawnXFactor();
        SpawnHeart();
        SpawnBerry();
        SpawnSun();
        SpawnAlcohol();
        SpawnOxygen();
        
    }

    private void OnTriggerExit(Collider other){

            groundSpawn.SpawnTile();
            
            Destroy(gameObject, 3.8f);

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


    public GameObject tree2;

    void SpawnTree2(){

        int index = Random.Range(30, 38);
        Transform spawnPoint = transform.GetChild(index).transform;

        Instantiate(tree2, spawnPoint.position, Quaternion.identity, transform);

    }

    public GameObject branch;

    void SpawnBranch(){

        int rand = Random.Range(1, 4);

        if (rand == 2){

        int index = Random.Range(38, 41);
        Transform spawnPoint = transform.GetChild(index).transform;

        Instantiate(branch, spawnPoint.position, Quaternion.identity, transform);
        }
    }

    public GameObject xFactor;

    void SpawnXFactor(){
        int rand = Random.Range(1, 11);
        if (rand == 3){
        GameObject temp = Instantiate(xFactor, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    public GameObject heart;

    void SpawnHeart(){
        int rand = Random.Range(1, 11);
        if (rand == 4){
        GameObject temp = Instantiate(heart, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    public GameObject stawberry;

    void SpawnBerry(){
        int rand = Random.Range(1, 25);
        if (rand == 5){
        GameObject temp = Instantiate(stawberry, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    public GameObject sun;

    void SpawnSun(){
        int rand = Random.Range(1, 11);
        if (rand == 6){
        GameObject temp = Instantiate(sun, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    public GameObject alcohol;

    void SpawnAlcohol(){
        int rand = Random.Range(1, 11);
        if (rand == 7){
        GameObject temp = Instantiate(alcohol, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    public GameObject oxygen;

    void SpawnOxygen(){
        int rand = Random.Range(1, 11);
        if (rand == 8){
        GameObject temp = Instantiate(oxygen, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider){

            Vector3 point = new Vector3(
                Random.Range(collider.bounds.min.x, collider.bounds.max.x),
                Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

            if (point != collider.ClosestPoint(point)){
                point = GetRandomPointInCollider(collider);
            }

            point.y = 1;
            return point;

    }

}
