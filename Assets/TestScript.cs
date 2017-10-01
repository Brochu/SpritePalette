using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
	[SerializeField] private Texture2D[] _tex;
	[SerializeField] private Material _mat;
	[SerializeField] private RawImage _image;
	[SerializeField] private int _time = 100;

	private int i = 0;
	private int index = 0;

	protected void Update()
	{
		_mat.SetTexture("_lut", _tex[index]);

		++i;
		if (i >= _time)
		{
			i = 0;
			index = (index + 1) % _tex.Length;
		}
	}
}