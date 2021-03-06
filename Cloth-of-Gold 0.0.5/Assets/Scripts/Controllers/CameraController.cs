using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private WorldController _worldController;

    [SerializeField] public Camera cam;

    private float _camHeight;
    private float _camWidth;
    private float _camLeftBound;
    private float _camUpperBound;
    private float _camRightBound;
    private float _camLowerBound;
    [SerializeField] private float zoomStepSize;
    [SerializeField] private float zoomMin;
    [SerializeField] private float zoomMax;

    private float _speed = 5;

    private void Awake()
    {
        GetCameraDimensions();
        MoveToCenter();
    }

    private void Start()
    {
        //Button zoomInBtn = zoomInButton.GetComponent<Button>();
        //zoomInBtn.onClick.AddListener(ZoomIn);
        //Button zoomOutBtn = zoomOutButton.GetComponent<Button>();
        //zoomOutBtn.onClick.AddListener(ZoomOut);

        // yield return new WaitForSeconds(1);
        
    }

    void Update()
    {
        CameraPan();
        FastPan();
        ZoomIn();
        ZoomOut();
        
    }

    private void GetCameraDimensions()
    {
        this._camHeight = 2f * cam.orthographicSize;
        this._camWidth = 2f * cam.orthographicSize * cam.aspect;

        this._camLeftBound = -((_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2) - _camWidth / 2)
                             + (_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2)
                             - 1;
        this._camRightBound = ((_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2) - _camWidth / 2)
                             + (_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2)
                             + 1;
        this._camLowerBound = -((_worldController.getWorldSizeInChunks.y * _worldController.getChunkSizeInTiles / 2) - _camHeight / 2)
                             + (_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2)
                             - 2;
        this._camUpperBound = ((_worldController.getWorldSizeInChunks.y * _worldController.getChunkSizeInTiles / 2) - _camHeight / 2)
                             + (_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2)
                             + 4;
    }

    private void MoveToCenter()
    {
        transform.position = new Vector3(_worldController.getWorldSizeInChunks.x * _worldController.getChunkSizeInTiles / 2,
                                            _worldController.getWorldSizeInChunks.y * _worldController.getChunkSizeInTiles / 2,
                                            transform.position.z);
    }

    private void CameraPan()
    {
            float xAxisValue = Input.GetAxisRaw("Horizontal") * -(1 / _speed);
            float yAxisValue = Input.GetAxisRaw("Vertical") * -(1 / _speed);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x - xAxisValue, _camLeftBound, _camRightBound),
                                             Mathf.Clamp(transform.position.y - yAxisValue, _camLowerBound, _camUpperBound),
                                                         transform.position.z);
    }

    private void FastPan()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))

            _speed /= 2;

        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))

            _speed *= 2;
    }

    public void ZoomIn()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Plus))
            transform.localScale = new Vector3(Mathf.Clamp(transform.localScale.x - zoomStepSize, zoomMin, zoomMax),
                                         Mathf.Clamp(transform.localScale.y - zoomStepSize, zoomMin, zoomMax),
                                                     transform.localScale.z);
    }

    public void ZoomOut()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Minus))
            transform.localScale = new Vector3(Mathf.Clamp(transform.localScale.x + zoomStepSize, zoomMin, zoomMax),
                                          Mathf.Clamp(transform.localScale.y + zoomStepSize, zoomMin, zoomMax),
                                                      transform.localScale.z);
    }
}
