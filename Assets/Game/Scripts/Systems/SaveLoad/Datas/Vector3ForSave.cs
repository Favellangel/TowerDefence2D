using System;
using UnityEngine;

[Serializable]
public struct Vector3ForSave
{
    public float x;
    public float y;
    public float z;

    public Vector3ForSave(Vector3 newVector)
    {
        x = newVector.x;
        y = newVector.y;
        z = newVector.z;
    }

    public Vector3ForSave(Quaternion quaternion)
    {
        x = quaternion.x;
        y = quaternion.y;
        z = quaternion.z;
    }

    public Vector3 ConvertToVector3()
    {
        Vector3 tmp;
        tmp.x = x;
        tmp.y = y;
        tmp.z = z;
        return tmp;
    }

    public Quaternion ConvertToQuaternion()
    {
        Quaternion tmp = new Quaternion();
        tmp.x = x;
        tmp.y = y;
        tmp.z = z;
        return tmp;
    }
}
