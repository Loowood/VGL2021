using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JetonManager : MonoBehaviour
{
	[SerializeField]
	private int nbJetons;
	public Text jetonsText;

	public int jetonsPerCoin = 10;

	public GameObject insertCoinBtn;

    private void Start()
    {
		insertCoinBtn.SetActive(false);
		nbJetons = jetonsPerCoin;
		jetonsText.text = nbJetons + " coins";
    }

    public void addJeton(int nb)
    {
		nbJetons += nb;
		jetonsText.text = nbJetons + " coins";
	}

	public void removeJeton(int nb)
    {
		nbJetons -= nb;
		if (nbJetons <= 0)
		{
			nbJetons = 0;
			insertCoinBtn.SetActive(true);
		}
		jetonsText.text = nbJetons + " coins";
	}

	public void setNbJetons(int nb)
    {
		nbJetons = nb;
		jetonsText.text = nbJetons + " coins";
	}

	public int getNbJetons()
    {
		return nbJetons;
    }

	// Pièces
	public void insertCoin()
    {
		addJeton(jetonsPerCoin);
		insertCoinBtn.SetActive(false);
    }
}
