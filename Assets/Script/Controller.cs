using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Stack<Command> commands = new Stack<Command>();

    private void Update()
    {
        if(commands.Count> 0)
        {
            Command cmd = commands.Pop();
            if(cmd != null)
            {
                cmd.Start();
            }


        }


    }

}
