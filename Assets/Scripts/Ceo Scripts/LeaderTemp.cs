using UnityEngine;

public class LeaderTemp : MonoBehaviour {

    private Vector3 _dragOffset;
    private Camera _cam;

    public GameObject Text;

    


    [SerializeField] private float _speed = 45;

    void Start()
    {
        Text.SetActive(false);
        
    }

    void Awake() {
        _cam = Camera.main;
    }

    void OnMouseDown() {
        _dragOffset = transform.position - GetMousePos();
        int xcount = Random.Range(1, 100000);
        string ram = xcount.ToString();
        this.name = ram;
    }

    void OnMouseDrag() {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * 3/Time.deltaTime) ;
    }
    void OnMouseOver()
    {
        if(this.name == "MuskLord"){
            print("MuskLord");
            Text.SetActive(true);
            
        }
        else if(this.name == "BezosBreaker"){
            print("BezosBreaker");
            Text.SetActive(true);
        }
        else if(this.name == "AmericanPysco"){
            print("AmericanPysco");
            Text.SetActive(true);
        }
        else if(this.name == "LargeArms"){
            print("LargeArms");
            Text.SetActive(true);   
        }
    }

    void OnMouseExit()
    {
        if(this.name == "MuskLord"){
            print("MuskLord");
            Text.SetActive(false);
            
        }
        else if(this.name == "BezosBreaker"){
            print("BezosBreaker");
            Text.SetActive(false);
        }
        else if(this.name == "AmericanPysco"){
            print("AmericanPysco");
            Text.SetActive(false);
        }
        else if(this.name == "LargeArms"){
            print("LargeArms");
            Text.SetActive(false);
        }
    }

    Vector3 GetMousePos() {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}