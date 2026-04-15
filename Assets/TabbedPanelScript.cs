using System.Collections.Generic;
using UnityEngine;

public class TabbedPanelScript : MonoBehaviour
{
    [Header("Configuration des Onglets")]
    [Tooltip("Glissez ici toutes les pages (Panels) de votre widget")]
    public List<GameObject> pagesContenu;

    void Start()
    {
        // Au démarrage, on affiche la première page (index 0) par défaut
        AfficherPage(0);
    }

    // Cette fonction publique sera appelée par nos boutons
    public void AfficherPage(int indexDemande)
    {
        // On vérifie que la liste n'est pas vide pour éviter les erreurs
        if (pagesContenu == null || pagesContenu.Count == 0) return;

        // On passe en revue toutes les pages de notre liste
        for (int i = 0; i < pagesContenu.Count; i++)
        {
            // Si le numéro de la page correspond au bouton cliqué...
            if (i == indexDemande)
            {
                pagesContenu[i].SetActive(true); // On l'affiche
            }
            else
            {
                pagesContenu[i].SetActive(false); // On la cache
            }
        }
    }
}