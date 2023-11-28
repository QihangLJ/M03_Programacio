## Exercici 2: M05UF2

### Exercici 1 - M03UF2:

#### A) Proves funcionals: (caixa negra)

1. Classes d'equivalencia:
- El primer nombre ha de se mes gran de 0 i no pot ser decimal. (nombres naturals)
- El segon nombre ha de se mes gran de 0 i no pot ser decimal. (nombres naturals)

2. Valors limit:
- Els valors per sota de 0 (inclos), estan fora del rang demanat. (misatge d'error)
- Els valors amb decimals son invalids pel nostre programa. (misatge d'error)
- El 2147483647 es el valor maxim que pot guardar la nostra variable "int", els valors per sobra d'aquest nombre, peta la maquina. (El programa peta)
- El -2147483647 es el valor minim que pot guardar la nostra variable "int", els valors per sota d'aquest nombre, peta la maquina. (El programa peta)

3. Classes valides:
- 1, 20, 300, 450, 501, 1250, 3020, 12345

4. Classes invalides:
- -200, -122, 0, 1.5, 100.25, 38912.123121, 2147483647000

### Exercici 2 - M03UF2:

#### A) Proves funcionals: (caixa negra)

1. Classes d'equivalencia:
- Base, qualsevol nombre enter ha de ser acceptada.
- Exponent, qualsevol nombre enter ha de ser acceptada.

2. Valors limit:
- El limit esta en la capacitat de la memoria de la variable que te per guardar el valor.
- Els nombres amb decimals.

3. Classes valides:
- Base: 0, 1, 2, 3, 50, 100...
- Expo: -2, -1, 0, 1, 2, 3...

4. Classes invalides:
- Base: 0.5, 38947298263892, 324235235.235235235, -124124325352
- Expo: -0.50, 1298709127490217, -23127398172983
