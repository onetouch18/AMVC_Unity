using UnityEngine;

public class CubeView : TaskElement {

    void Start() { app.controller.OnColorChange(this.gameObject.GetComponent<Renderer>()); }
}
