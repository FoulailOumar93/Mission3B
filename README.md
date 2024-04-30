# Mission 3B
# PROJET APPLI-CR - Portefeuille de Compétences

## Participation à un projet d’évolution d’un système informatique (SI)
Ce projet implique des solutions applicatives et d’infrastructure, portant principalement sur le domaine de spécialité du candidat. Les activités englobées sont :

- **A1.1.1** : Analyse du cahier des charges d'un service à produire.
- **A1.1.3** : Étude des exigences liées à la qualité attendue d'un service.
- **A1.3.1** : Test d'intégration et d'acceptation d'un service.
- **A1.3.4** : Déploiement d'un service.
- **A1.4.1** : Participation à un projet.
- **A4.1.6** : Gestion d’environnements de développement et de test.
- **A4.1.7** : Développement, utilisation ou adaptation de composants logiciels.
- **A4.1.8** : Réalisation des tests nécessaires à la validation d’éléments adaptés ou développés.
- **A4.1.9** : Rédaction d’une documentation technique.
- **A4.1.10** : Rédaction d’une documentation d’utilisation.
- **A2.3.1** : Identification, qualification et évaluation d'un problème.
- **A4.1.1** : Proposition d'une solution applicative.
- **A4.1.2** : Conception ou adaptation de l'interface utilisateur d'une solution applicative.
- **A4.2.3** : Réalisation des tests nécessaires à la mise en production d'éléments mis à jour.

## Cas d’utilisation

### Cas 1 : Gestion des Médicaments
**Acteur** : Secrétaire

**Scénario Nominal** :
1. La secrétaire demande à gérer les médicaments.
2. Le système affiche un formulaire pour sélectionner la famille du médicament.
3. La secrétaire sélectionne la famille.
4. Le système affiche la liste des médicaments de cette famille avec toutes leurs informations.

**Extensions** :
- Si la famille n'existe pas, la secrétaire peut créer une nouvelle famille via un formulaire fourni par le système, puis ajouter ou modifier des médicaments au sein de cette famille.

**Scénarios Alternatifs** :
- Si les informations saisies sont invalides, le système affiche des messages d'erreur et permet à la secrétaire de corriger les erreurs.

### Cas 2 : Visualisation des Médicaments Offerts
**Acteur** : Secrétaire

**Scénario Nominal** :
1. La secrétaire demande à voir la liste des médicaments offerts.
2. Le système affiche un formulaire pour sélectionner la famille d’un médicament.
3. La secrétaire sélectionne la famille.
4. Le système affiche la liste des médicaments offerts, triée par le nombre de médicaments offerts pour chaque item.

**Extension** :
- La secrétaire peut demander une exportation de cette liste vers un fichier XML que le système génère et fournit.

Cette restructuration vise à clarifier les informations et à rendre le document plus accessible et compréhensible.
