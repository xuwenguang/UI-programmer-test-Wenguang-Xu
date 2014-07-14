using UnityEngine;  
using System;
using System.Collections;  


public class Calculator : MonoBehaviour { 
	
	
	public string strPutkeyCode;  
	
	private UILabel strResult;   //result label  
	
	public static string str1;  //the first input number  
	
	public static string str2;  //second number  
	
	public static string strOpt;    //operators  
	
	
	int sum = 0; 

	void Start () { 
		strResult=GameObject.Find("2dDisplay/Label").GetComponent<UILabel>();
	} 

	
	
	void OnMouseDown() 
		
	{ 
		Debug.Log ("clicked");
		try
		{
			if(strPutkeyCode == "=") 
				
			{ 
				if(strOpt == "/") 		
				{ 
					sum =int.Parse(str2)/int.Parse(str1);  
				} 
				
				else if(strOpt == "*") 
				{ 
					sum =int.Parse(str1)*int.Parse(str2);  	
				} 
				else if(strOpt == "+") 	
				{ 
					sum =int.Parse(str1)+int.Parse(str2);  	
				} 
				else if(strOpt == "-") 	
				{ 
					sum =int.Parse(str2)-int.Parse(str1);  	
				} 
				
				str1 = "";  
				
				str2 = sum.ToString();  
				
				Debug.Log(sum);  
				
				strResult.text = sum.ToString();  
				
			}
		}
		catch(Exception e)
		{}

		if(strPutkeyCode == "-"||strPutkeyCode == "+") 
			
		{ 
			
			strOpt=strPutkeyCode;   
			if(str1 != "") 
				
			{ 
				
				str2=str1;    
				
			} 
			
			
			strResult.text = str2;  
			
			Debug.Log("code---");  
			
			str1="";  
			
		} 

		if(strPutkeyCode =="1" ||strPutkeyCode =="2" ||strPutkeyCode =="3" ||strPutkeyCode =="4" ||  
		   
		   strPutkeyCode =="5" ||strPutkeyCode =="6" ||strPutkeyCode =="7" ||strPutkeyCode =="8" ||  
		   
		   strPutkeyCode =="9" ||strPutkeyCode =="0") 
			
		{ 
			
			str1 += strPutkeyCode;  
			
			strResult.text = str1;  
			
			Debug.Log(str1);  
			
		} 
		
	} 

	//for the clear button
	public void clear()
	{
		Debug.Log("CE");  
		
		strResult.text = "0";  
		
		sum = 0;  
		
		str1 = "";  
		
		str2 = "";  
	}
} 