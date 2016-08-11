using UnityEngine;

public class TaskElement : MonoBehaviour
{
    public TaskApplication app
    {
        get { return GameObject.FindObjectOfType<TaskApplication>(); }
    }
}

public class TaskApplication : MonoBehaviour {

    public TaskModel model;
    public TaskView view;
    public TaskController controller;
}
