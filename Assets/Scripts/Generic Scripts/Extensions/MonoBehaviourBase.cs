﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonoBehaviourBase : MonoBehaviour {

    //Defined in the common base class for all mono behaviours
    public I GetInterfaceComponent<I>() where I : class
    {
        return GetComponent(typeof(I)) as I;
    }

    public static List<I> FindObjectsOfInterface<I>() where I : class
    {
        MonoBehaviour[] monoBehaviours = FindObjectsOfType<MonoBehaviour>();
        List<I> list = new List<I>();

        foreach (MonoBehaviour behaviour in monoBehaviours)
        {
            I component = behaviour.GetComponent(typeof(I)) as I;

            if (component != null)
            {
                list.Add(component);
            }
        }

        return list;
    }
}
