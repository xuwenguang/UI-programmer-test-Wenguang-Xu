using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public GameObject[] calculatorLayouts;
	public GameObject[] wizards;
	private int currentWizardIndex=0;
	private bool inCalculator=false;
	private string calculatorLayout="line_layout";
	private string name;
	public GameObject nameLabel;
	public GameObject layoutLabel;
	public GameObject calculatorDisplay;

	// Use this for initialization
	void Start () {
		//set up the default calculator layout
		layoutLabel.GetComponent<UILabel> ().text = calculatorLayout;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void next()
	{
		if(!inCalculator)
		{
			wizards [currentWizardIndex].SetActive (false);
			if(currentWizardIndex<wizards.Length-1)
			{
				currentWizardIndex++;
			}
			wizards[currentWizardIndex].SetActive(true);
		}
	}

	public void back()
	{
		if(inCalculator)
		{
			hideCalculator();
			inCalculator=false;
			hideCalculator();
		}

		wizards [currentWizardIndex].SetActive (false);
		if(currentWizardIndex>0)
		{
			currentWizardIndex--;
		}
		wizards [currentWizardIndex].SetActive (true);
	}

	public void startCalculator()
	{
		inCalculator = true;
		wizards [currentWizardIndex].SetActive (false);
		showCalculator ();
	}

	public void clear()
	{

	}

	public void showCalculator()
	{
		calculatorDisplay.SetActive (true);
		switch (calculatorLayout)
		{
		case "tranditional_layout" :
			for(int i=0; i<calculatorLayouts.Length;i++)
			{
				if(calculatorLayouts[i].name.Contains("tranditional"))
				{
					calculatorLayouts[i].SetActive(true);
				}
			}
			break;
		case "line_layout" :
			for(int i=0; i<calculatorLayouts.Length;i++)
			{
				if(calculatorLayouts[i].name.Contains("line"))
				{
					calculatorLayouts[i].SetActive(true);
				}
			}
			break;

		}

	}

	public void hideCalculator()
	{
		for(int i=0; i<calculatorLayouts.Length;i++)
		{
			calculatorLayouts[i].SetActive(false);
		}
		calculatorDisplay.SetActive (false);
	}

	public void setTranditionalLayout()
	{
		if (calculatorLayout != "tranditional_layout")
			calculatorLayout = "tranditional_layout";
		layoutLabel.GetComponent<UILabel> ().text = calculatorLayout;
	}

	public void setLineLayout()
	{
		if (calculatorLayout != "line_layout")
			calculatorLayout = "line_layout";
		layoutLabel.GetComponent<UILabel> ().text = calculatorLayout;
	}

	public void inputName()
	{
		//get text from nameInputField
		name =GameObject.Find ("nameInputField/Label").GetComponent<UILabel>().text;
		nameLabel.GetComponent<UILabel> ().text = name;
	}
}
