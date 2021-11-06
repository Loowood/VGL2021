using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetonManager : MonoBehaviour
{
	public static JetonManager instance;
	[SerializeField]
	private int nbJetons;


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

	public void addJeton(int nb)
    {
		nbJetons += nb;
    }

	public void removeJeton(int nb)
    {
		nbJetons -= nb;
		if (nbJetons < 0)
			nbJetons = 0;
    }

	public void setNbJetons(int nb)
    {
		nbJetons = nb;
    }

	public int getNbJetons()
    {
		return nbJetons;
    }
}
