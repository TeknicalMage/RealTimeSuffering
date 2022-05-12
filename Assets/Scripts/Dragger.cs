using UnityEngine;

public class Dragger : MonoBehaviour {

    private Vector3 _dragOffset;
    private Camera _cam;

    [SerializeField] private float _speed = 45;

    void Awake() {
        _cam = Camera.main;
    }

    void OnMouseDown() {

        string identity;
        identity = this.name;
        _dragOffset = transform.position - GetMousePos();

        if(identity.Contains("SolarField")){
            int xcount = Random.Range(1, 10000000);
            string ram = xcount.ToString();
            this.name = "SolarField" + ram;;
        }else if(identity.Contains("City")){
            int xcount = Random.Range(1, 10000000);
            string ram = xcount.ToString();
            this.name = "City" + ram;;
        }
        
        //int xcount = Random.Range(1, 100000);
        //string ram = xcount.ToString();
        //this.name = ram;
    }

    void OnMouseDrag() {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * 3/Time.deltaTime) ;
    }

    void OnMouseUp(){
    }

    Vector3 GetMousePos() {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}