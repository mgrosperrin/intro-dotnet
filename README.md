# intro-dotnet
## Objectif Extreme carpaccio

Calculer le montant de la facture pour une commande


## Comment calculer ?

1. Faire la somme des montants des �l�ments de la commande
2. Appliquer la r�duction
3. Ajouter les taxes
4. Arrondir � deux chiffres apr�s la virgule

### R�duction

- `PayThePrice` : pas de r�duction
- `HalfPrice` : 50% de r�duction
- `Standard` :

| Montant avant r�duction | R�duction |
| -- | -- |
|X<100|0%|
|100<=x<500|3%|
|500<=x<700|5%|
|700<=x<1000|7%|
|1000<=x<5000|10%|
|5000<=x|15%|


### Taxes

- `FR` : 20%
- `UK` : 21%
- `PT` : 23%
