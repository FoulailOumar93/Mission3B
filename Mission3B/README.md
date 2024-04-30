**Mission 3 version b** 

![](Aspose.Words.8cea9e00-aa2d-4a63-bb6d-c5ce8c29405a.001.png)

**PROJET APPLI-CR Activités du portefeuille de compétences** 

- Participation à un projet d’évolution d’un SI (solution applicative et d’infrastructure portant prioritairement sur le domaine de spécialité du candidat) 
- A1.1.1 , Analyse du cahier des charges d'un service à produire 
- A1.1.3 , Étude des exigences liées à la qualité attendue d'un service 
- A1.3.1 , Test d'intégration et d'acceptation d'un service  
- A1.3.4 , Déploiement d'un service  
- A1.4.1 , Participation  à un projet  
- A4.1.6 - Gestion d’environnements de développement et de test 
- A4.1.8 Réalisation des tests nécessaires à la validation d’éléments adaptés ou développés 
- A4.1.7 Développement, utilisation ou adaptation de composants logiciels 
- A4.1.9 - Rédaction d’une documentation technique 
- A4.1.10 Rédaction d’une documentation d’utilisation 
- A2.3.1 , Identification, qualification et évaluation d'un problème  
- A4.1.1 , Proposition d'une solution applicative 
- A4.1.2 , Conception ou adaptation de l'interface utilisateur d'une solution applicative  
- A4.2.3 , Réalisation des tests nécessaires à la mise en production d'éléments mis à jour  

**Les cas d’utilisation ![](Aspose.Words.8cea9e00-aa2d-4a63-bb6d-c5ce8c29405a.002.png)**

Description du cas 

Nom : gestion des médicaments Acteur : la secrétaire 

Scénario nominal 

1. La secrétaire demande à gérer les médicaments 
1. Le système retourne un formulaire permettant de sélectionner la famille du médicament 
1. La secrétaire sélectionne la famille 
1. Le système retourne la liste des médicaments de la famille concernée avec toutes ses informations 

Extensions  

3.1 La famille n’existe pas. La secrétaire demande à créer une nouvelle famille 

1. Le système retourne un formulaire de création d’une famille 
1. La secrétaire saisit les informations et valide 
1. Le système enregistre cette nouvelle famille 
1. La secrétaire modifie une ou des informations sur un médicament et valide 
   1. Le système enregistre ces modifications 
1. La secrétaire ajoute un nouveau médicament de la famille et valide 
   1. Le système enregistre ce nouveau médicament 
1. La secrétaire demande à supprimer un médicament 
1. Le système supprime le médicament  

Scénarios alternatifs 

3.1.3.1 Les informations ne sont pas valides. Le système en informe la secrétaire. Retour à                3.1.2 

2. Les modifications ne sont pas cohérentes 
   1. Le système retourne un message d’erreurs sur les informations incohérentes. Retour à 5.1 
2. Les modifications ne sont pas cohérentes 
   1. Le système retourne un message d’erreurs sur les informations incohérentes. Retour à 5.2 
2. Le médicament à supprimer est concerné pas des rapports. 

5.3.2.1  Le système ne supprime pas ce médicament et en informe l’utilisateur 

Description du cas 

Nom : Voir la liste  des médicaments offerts Acteur : la secrétaire 

Scénario nominal 

1. La secrétaire demande à voir la liste des médicaments offerts 
1. Le système retourne un formulaire permettant de sélectionner la famille d’un médicament 
1. La secrétaire sélectionne la famille 
1. Le système retourne la liste des médicaments concernés par des dons, triés pour chaque médicament par le nombre de médicaments offerts 

Extension 

5. La secrétaire demande une exportation des médicaments concernés par les dons vers un fichier XML 
5. Le système retourne le fichier XML 
