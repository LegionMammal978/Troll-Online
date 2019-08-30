# Troll-Online

## Descargar

Para instalar la version de x64 haz [click aqui](https://www.mediafire.com/file/4knvob8nmyl7m77/Troll_Online_x64_Setup.exe/file)

Para instalar la version de x86 haz [click aqui](https://www.mediafire.com/file/01y51dzejeskdvx/Troll_Online_x86_Setup.exe/file)

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

Para los archivos debes usar ♫↕! para apuntar a el archivo y usar csis para apuntar a la variable donde guardar el string con el contenido del archivo.

```tllonline
♫↕!ARCHIVOcsisVARIABLE
```
**Ningun apuntador es opcional**

**Este metodo es asincrono osea si el archivo es gande o tu disco duro no es eficiente puede tardar un poco**

### Online

Para conectarte a un sitio web usaremos los siguientes apuntadores:

l},ºVARIABLE => para poner la variable a almacenar el sitio web (html).

<VARIABLE => para poner la variable a almacenar el status code del sitio web.

¿LINK => El sitio web en forma de url no de variables

¿AUTORIZACION => El header de "Authorization" en forma de texto no de variable 
```tllonline
l},ºVARIABLE<VARIABLE¿LINK¿AUTORIZACION
```

**Ningun apuntador es opcional**

**Este metodo es asincrono osea que el codigo se va a seguir ejecutando aunque no termine de cargar el sitio web**

### Operadores de cambios

Los operadores de cambio sirven para modificar el valor de una variable de manera eficiente.

#### Booleans

la instruccion !7; permite invertir el valor de un bool.

Ejemplo:
```tllonline
!7;VARIABLE
```

#### Numeros

La instruccion \_\_RPD sirve para restar una variable (number) por un numero que no puede ser una variable y \_\_DPR es lo mismo pero suma.

Ejemplos:
```tllonline
VARIABLE__RPDnumero
VARIABLE__DPRnumero
```

### Control de tiempo

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

#### match

Para hacer el match \_\_kpEXP\_VARIABLE1\_VARIABLE2 siendo EXP la expresion regular, variable1 la variable donde buscar y variable2 que sirve para almacenar true o false dependiendo el resultado.

## Proximamente

+ Funcion para generar repeticiones a base de un x tiempo en otro hilo de ejecucion.
+ Funcion de extracion de caracteres para strings.
+ websocket (actualizacion lejana)

**Esperen estos cambios los proximos meses**

Unete a https://discord.gg/kt3jQjz para estar al tanto.

## Filosofia

+ Mejor inentendible que entendible.
+ Es mejor -yes que -y
+ El español debe ser algo obligatorio.
+ Los comentarios son para novatos.
+ Es mejor algo inutil e inentendible que algo util y entendible.
+ Los arrays son muy utiles con un bucle for.
