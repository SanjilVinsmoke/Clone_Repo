using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
	[SerializeField] Text dialogText;
	[SerializeField] GameObject dialogBox;
	[SerializeField] string[] dialogLines;
	int currentLine;
	private bool justStarted;
	public bool canActivate;
	bool isShowing = false;
	// Use this for initialization
	void Start()
	{
		dialogText.text = dialogLines[currentLine];
	}

	// Update is called once per frame
	void Update()
	{
		if (canActivate && !isShowing )
		{
			ShowDialog();
			isShowing = true;
		}
		if (dialogBox.activeInHierarchy)
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				if (!justStarted)
				{
					currentLine++;
					if (currentLine >= dialogLines.Length)
					{
						dialogBox.SetActive(false);
					}
					else
					{
						dialogText.text = dialogLines[currentLine];
					}
				}
				else
				{
					justStarted = false;
				}
			}
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		print(other.name);
		if (other.CompareTag("Player"))
		{
			canActivate = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			canActivate = false;
		}
	}
	public void ShowDialog()
	{
		
		currentLine = 0;
		
		dialogBox.SetActive(true);
		justStarted = true;
	}

	
}