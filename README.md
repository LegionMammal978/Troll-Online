# Troll-Online

## Descargar

Para instalar la version de x64 haz [click aqui](https://www.mediafire.com/file/es2lkb4hkk2nphm/Troll_Online_x64_Setup.exe/file)

Para instalar la version de x86 haz [click aqui](https://www.mediafire.com/file/lqyn1ittvd9t31c/Troll_Online_x86_Setup.exe/file)

## Que es esto?

Esto es un lenguaje de programacion esoterico mal hecho y como evidencia de eso no se admite el caracter ￿ porque lo vas a romper todo.

## Como se usa?

Abres el programa de ahi tienes dos comandos "salir" y "ejecutar" escribes "ejecutar" y luego te pedira que ingreses el archivo .tllonline con el codigo a ejecutar.

## Documentacion

Todas estas cosas deben estar separadas por saltos de lineas.

### Titulo

para poner titulo pon <> al comienso del codigo y despues escribe adelante el codigo del comienzo (no dejes saltos de linea).

```tllonline
<TITULO>k¨ç]777
```

### variables

en este lenguaje hay 24 variables para asignarles un valor.

abcdefghij (string)

klmnñopqrs (numbers)

t array (number)

u array (string)

v array (bool)

wxyz (bool)

Para añadir un valor a una variable debes usar ¨ç]

```tllonline
VALOR¨ç]VARIABLE
```

en caso de querer ponerle valor a un array debes usar º-/* para separar las variables

```tllonline
VALORº-/*VALOR¨ç]VARIABLE
```

para ponerle valor a una variable desde un array usa ARRAY-\_-NUMERO

```tllonline
ARRAY-_-NUMERO¨ç]VARIABLE
```
**Los numneros son de tipo double**

**Las variables que son arrays y strings ya se dijeron arriba.**

**Los string no necesitan "", '', `` o etc**

### Condicionales

**Dentro de los if no puedo haber otro if o un bucle**

Los if se deben usar ¿!ª# para las comparaciones de igualdad de dos variables.

```tllonline
VARIABLE¿!ª#VARIABLE
```
Despues de eso debe ir un espacio y podes escribir el codigo que quieras pero usando ◄► como saltos de lineas.

### Bucles

**Dentro de los blucles no puedo haber otro bucle o un if**

Para generar un bucle debes usar \_\_rap

Los bucle a diferencia de otros lenguajes les debes indicar con una variable el numero de repeticiones (debes utiliazar un numero entero para no hacer un bucle infinito).

```tllonline
__rapVARIABLE
```

Despues de eso debe ir un espacio y podes escribir el codigo que quieras pero usando ◄► como saltos de lineas.

### Consola

#### Entrada

La instruccion 👉👌 sirve para almacenar algo que el usuario escriba en la consola en una variable.

```tllonline
VARIABLE👉👌
```

#### Salida

Para imprimir algo en consola debes usar ↓ùp👌 seguido de una variable y para los arrays debes usar VARIABLE-\_-NUMERO

```tllonline
↓ùp👌VARIABLE 
```
Imprime cualquier variable incluso booleanos

## Archivos

### Abrir 

con el metodo yyyyVARIABLE1@VARIABLE2@VARIABLE3 puedes abrir un archivo o programa siendo la var1 la ruta, la var2 los argumentos y el var3 donde se almacenala la informacion (err, data).

ejemplo:
```tllonline
yyyyVARIABLE1@VARIABLE2@VARIABLE3
yyyyC:\Users\usuariogenerico\desktop\chicascalientes.exe@xd@VARIABLE3
```

**var1 y var2 pueden ser texto sin necesidad de haber sido guardado en una varible previamente**

### Editar

Para editar un archivo deberas usar 👌👈 poniendo la ruta del archivo atras y la variable con la cual se ara la modificacion adelante.

```tllonline
ARCHIVO👌👈VARIABLE
```

### Leer

Para los archivos debes usar ♫↕! para apuntar a el archivo y usar csis para apuntar a la variable donde guardar el string con el contenido del archivo.

```tllonline
♫↕!ARCHIVOcsisVARIABLE
```
**Ningun apuntador es opcional**

**Estos metodos son asincrono osea si el archivo es gande o tu disco duro no es eficiente puede tardar un poco**

### Online

Para conectarte a un sitio web usaremos los siguientes apuntadores:

l},ºVARIABLE => para poner la variable a almacenar el sitio web (html).

<VARIABLE => para poner la variable a almacenar el status code del sitio web.

¿LINK => El sitio web en forma de url no de variables

¿AUTORIZACION => El header de "Authorization" en forma de texto no de variable 

¿METODO|contenido|Content-Type => primero indicas el metodo (get delete post put (no se diferencian mayusculas y minusculas)) y en el estricto caso de que necesites enviar json o contenido extra en la peticion pon __|lo que necesites|Content Type__

```tllonline
l},ºVARIABLE<VARIABLE¿LINK¿AUTORIZACION¿METODO
l},ºVARIABLE<VARIABLE¿LINK¿AUTORIZACION¿gEt
l},ºVARIABLE<VARIABLE¿LINK¿AUTORIZACION¿METODO|lo que necesites|Content Type
l},ºVARIABLE<VARIABLE¿LINK¿AUTORIZACION¿put|{}|application/json
l},ºVARIABLE<VARIABLE¿VARIABLE¿AUTORIZACION¿put|VARIABLE|application/json
```

**Puedes usar variable string para el LINK y el contenido**

**Ningun apuntador es opcional**

**Este metodo es asincrono osea que el codigo se va a seguir ejecutando aunque no termine de cargar el sitio web**

### Operadores de cambios

Los operadores de cambio sirven para modificar el valor de una variable de manera eficiente.

#### strings

##### concat

-/aaVARIABLE1#VARIABLE2#VARIABLE3 es el metodo para unir un texto con otro **var1 + var2** y ese resultado se almacena el la var3.

Ejemplo:
```tllonline
-/aaVARIABLE1#VARIABLE2#VARIABLE3
```

##### substring

ggVARIABLE1¿VARIABLE2¿VARIABLE3¿VARIABLE4 sirve para controlar la cantidad de caracteres de una cadena la var1 es la cadena a modificar y la var4 es donde se almacenara el resultado. El var2 uno es el **startIndex** y el var3 es el **length** https://docs.microsoft.com/es-es/dotnet/api/system.string.substring?view=netframework-4.8#System_String_Substring_System_Int32_System_Int32_

Ejemplo:
```tllonline
ggVARIABLE1¿VARIABLE2¿VARIABLE3¿VARIABLE4
```

#### Booleans

la instruccion !7; permite invertir el valor de un bool.

Ejemplo:
```tllonline
!7;VARIABLE
```

#### Numeros

##### parseInt

☺VARIABLE1♥☻VARIABLE2 es la instruccion que se utilizara para trasformar una texto en numero. La var1 es el texto y el var2 donde se almacenara el numero.

Ejemplos:
```tllonline
☺VARIABLE1♥☻VARIABLE2
```

##### suma y resta

La instruccion \_\_RPD sirve para restar una variable (number) por un numero que no puede ser una variable y \_\_DPR es lo mismo pero suma.

Ejemplos:
```tllonline
VARIABLE__RPDnumero
VARIABLE__DPRnumero
```

### Control de ejecucion

#### rewind

Con la instruccion ñpqqVARIABLE vuelves a x linea de ejecucion del codigo por ejemplo estas en la linea 15 con esta funcion puedes volver a la linea 5,2 o cualquiera. La linea 1 es la numero 0, la 2 es la 1, etc.

Ejemplo:
```tllonline
ñpqqVARIABLE
```

#### sleep

Con la instruccion çlbv detienes la ejecucion de codigo por la cantidad de tiempo la cual debe tener una variable asignada en milisegundos.

Ejemplo:
```tllonline
çlbvVARIABLE
```

### Salir 

Usando la instruccion &{- cierras el programa automaticamente.

Ejemplo:
```tllonline
&{-
```

### expresiones regulares

Una expresión regular, o expresión racional,1​2​ es una secuencia de caracteres que conforma un patrón de búsqueda. -wikipedia

#### remplace

Para remplasar una parte de un string mediante una exprecion regular debes usar ¨#\_\_VARIABLE1\_EXP\_VARIABLE2\_VARIABLE3 siendo la variable1 el texto a modificar, el EXP la expresion regular, variable2 como el texto a colocar y variable3 como la variable donde se almacena el resultado de todo esto.

Ejemplo:
```tllonline
¨#__VARIABLE_EXP_VARIABLE2_VARIABLE3
```

#### match

Para hacer el match \_\_kpEXP\_VARIABLE1\_VARIABLE2 siendo EXP la expresion regular, variable1 la variable donde buscar y variable2 que sirve para almacenar true o false dependiendo el resultado.

Ejemplo:
```tllonline
__kpEXP_VARIABLE_VARIABLE2
```

## Proximamente

+ Funcion de extracion de caracteres para strings.
+ websocket (actualizacion lejana)
+ esperamos sus sugerencias.

**Esperen estos cambios los proximos meses**

Unete a https://discord.gg/kt3jQjz para estar al tanto.

## Filosofia

+ Mejor inentendible que entendible.
+ Es mejor -yes que -y
+ El español debe ser algo obligatorio.
+ Los comentarios son para novatos.
+ Es mejor algo inutil e inentendible que algo util y entendible.
+ Los arrays son muy utiles con un bucle for.
