using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JetonManager : MonoBehaviour
{
	public static JetonManager instance;
	[SerializeField]
	private int nbJetons;
	public Text jetonsText;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

    private void Start()
    {
		nbJetons = 20;
		jetonsText.text = nbJetons + " jetons";
    }

    public void addJeton(int nb)
    {
		nbJetons += nb;
		jetonsText.text = nbJetons + " jetons";
	}

	public void removeJeton(int nb)
    {
		nbJetons -= nb;
		if (nbJetons < 0)
			nbJetons = 0;
		jetonsText.text = nbJetons + " jetons";
	}

	public void setNbJetons(int nb)
    {
		nbJetons = nb;
		jetonsText.text = nbJetons + " jetons";
	}

	public int getNbJetons()
    {
		return nbJetons;
    }
}
