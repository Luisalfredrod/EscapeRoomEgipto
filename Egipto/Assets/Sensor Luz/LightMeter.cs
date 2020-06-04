﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMeter : MonoBehaviour
{
    public CharacterController Player;
    public Camera cam;
    public float Output;
    public float Sensitivity = 8.0f;
    public Material mat; //optional: highlighting a material accordingly to the Output data

    private Color MatCol; //optional color for the highlighted material
    private Rect rec = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
    private Transform _tr;
    private Color[] Samples = new Color[6];
    private float[] Brightness = new float[6];
    private Vector3[] camPOS = new Vector3[6];
    private Vector3[] camROT = new Vector3[6];
    private int i = 0;
    private float s = 10.0f;
    private float MoveSpeed;

    void Start()
    {
        mat.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
        mat.SetColor("_EmissionColor", MatCol * 0.0f);
        _tr = cam.transform;
        s -= Sensitivity;
        //front:
        camPOS[0] = new Vector3(0.0f, 0.0f, -1.5f);
        camROT[0] = new Vector3(0.0f, 0.0f, 0.0f);
        //back:
        camPOS[1] = new Vector3(0.0f, 0.0f, 1.5f);
        camROT[1] = new Vector3(180.0f, 0.0f, 0.0f);
        //top:
        camPOS[2] = new Vector3(0.0f, 1.5f, 0.0f);
        camROT[2] = new Vector3(90.0f, 0.0f, 0.0f);
        //bottom:
        camPOS[3] = new Vector3(0.0f, -1.5f, 0.0f);
        camROT[3] = new Vector3(-90.0f, 0.0f, 0.0f);
        //left:
        camPOS[4] = new Vector3(-1.5f, 0.0f, 0.0f);
        camROT[4] = new Vector3(0.0f, 90.0f, 0.0f);
        //right:
        camPOS[5] = new Vector3(1.5f, 0.0f, 0.0f);
        camROT[5] = new Vector3(0.0f, -90.0f, 0.0f);
        //ground: optional sample
        //camPOS[6] = new Vector3(0.0f, -1.5f, 0.0f);
        //camROT[6] = new Vector3(90.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        if (!Global.GamePaused)
        {
            SetVelocity();
            GetPix();
            SumPix();
        }
    }

    private void GetPix() 
    {
        //adjust camera:
        _tr.localPosition = camPOS[i];
        _tr.localRotation = Quaternion.Euler(camROT[i]);
        //get samples:
        Texture2D tex = new Texture2D(1, 1, TextureFormat.RGB24, false);
        //RenderTexture rt_temp = RenderTexture.GetTemporary(1, 1, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture rt_temp = new RenderTexture(1, 1, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture rt_prev = RenderTexture.active;
        cam.targetTexture = rt_temp;
        cam.Render();
        RenderTexture.active = rt_temp;
        tex.ReadPixels(rec, 0, 0, false);
        Samples[i] = tex.GetPixelBilinear(0, 0);

        //pixel brightness = (R+R+B+G+G+G)/6

        Brightness[i] += (Samples[i].r + Samples[i].r + Samples[i].b + Samples[i].g + Samples[i].g + Samples[i].g) / s;
        //cleanup:
        cam.targetTexture = null;
        RenderTexture.active = rt_prev;
        //RenderTexture.ReleaseTemporary(rt_temp);
        Destroy(rt_temp);
        Destroy(tex);
        Destroy(cam.targetTexture);
        //update index:
        i++;
    }

    private void SumPix()
    {
        Output = ((Brightness[0] + Brightness[1] + Brightness[2] + Brightness[3] + Brightness[4] + Brightness[5]) / s);

        if (Output > 0.0f)
            Output += MoveSpeed;//if it is not full darkness then add the movement speed

        if (Global.FlashOrEmergencyOn)
            Output += 2;

        if (i >= Samples.GetLength(0))
        {
            mat.SetColor("_EmissionColor", MatCol * Output);
            i = 0;
            BrightnessZero();
        }
    }

    private void BrightnessZero()
    {
        Brightness[0] = 0.0f;
        Brightness[1] = 0.0f;
        Brightness[2] = 0.0f;
        Brightness[3] = 0.0f;
        Brightness[4] = 0.0f;
        Brightness[5] = 0.0f;
    }

    //change player's visibility depending on how fast he is moving:
    private void SetVelocity()
    {
        MoveSpeed = Player.velocity.magnitude / 35.0F;
    }
}