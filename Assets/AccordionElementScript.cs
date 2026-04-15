using UnityEngine;

public class AccordionElementScript : MonoBehaviour
{
    [Header("Paramètres")]
    [Tooltip("Glissez ici le panneau à ouvrir/fermer (Contenu_Panel)")]
    public GameObject panneauContenu;

    // Cette fonction sera appelée quand on cliquera sur le bouton
    public void TogglePanneau()
    {
        // On vérifie qu'on a bien assigné le panneau pour éviter les erreurs
        if (panneauContenu != null)
        {
            // On regarde l'état actuel du panneau (est-il allumé ou éteint ?)
            bool estAllume = panneauContenu.activeSelf;
            
            // On l'inverse ! S'il est allumé, on l'éteint. S'il est éteint, on l'allume.
            panneauContenu.SetActive(!estAllume);
        }
    }
}