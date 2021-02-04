using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WordDisplay : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word)
	{
		text.text = word;
        Color randColor = genRandomColor();
        text.color = randColor;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
        Color randColor = genRandomColor();
        text.color = randColor;
	}

    public Color genRandomColor()
    {
        float r, g, b;
        r = UnityEngine.Random.Range(0f, 1f);
        g = UnityEngine.Random.Range(0f, 1f);
        b = UnityEngine.Random.Range(0f, 1f);

        return new Color(r, g, b);
    }

    
	public void RemoveWord ()
	{
		Destroy(gameObject);
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
	}

}
