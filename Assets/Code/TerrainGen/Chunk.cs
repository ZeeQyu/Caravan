﻿using UnityEngine;
using System.Collections;
using System.Threading;
using System;

public class Chunk
{
    // Member variables
    private GameObject _gameObject;
    public GameObject gameObject
    {
        get { return _gameObject; }
    }

    private Vector2 _coords;
    public Vector2 coords
    {
        get { return _coords; }
    }


    private NoiseData _noiseData;
    public NoiseData noiseData
    {
        set { _noiseData = value; }
    }

    // Constructor
    public Chunk(Vector2 inChunkCoords, GameObject inGameObject)
    {
        _gameObject = inGameObject;
        _coords = inChunkCoords;
    }
}