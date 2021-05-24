# tp5---2021-JIVitian
tp5---2021-JIVitian created by GitHub Classroom

## Quinto Trabajo Práctico de Taller de Lenguajes 1 de Licenciautra Informatica - PU. FACET-UNT

### Respuestas a las preguntas del TP:
### Punto 4:
* ***¿String es una tipo por valor o un tipo por referencia?***  
	En c# el tipo string es en realidad un Objeto y no un tipo de variable primitiva, y en dicho lenguaje todos los objetos son tipos por referencia.
* ***¿Qué secuencias de escape tiene el tipo string?***  
	Las secuencias de escape que tiene el tipo string son:  
	  	\\'	Comilla simple  
		\\"	Comilla doble  
		\\	Barra diagonal inversa  
		\0	Null  
		\a	Alerta  
		\b	Retroceso  
		\f	Avance de página  
		\n	Nueva línea  
		\r	Retorno de carro  
		\t	Tabulación horizontal  
		\v	Tabulación vertical  
		\u	Secuencia de escape Unicode (UTF-16)  
		\U	Secuencia de escape Unicode (UTF-32)  
		\x	Secuencia de escape Unicode similar a "\u" excepto con longitud variable  
* ***¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?***  
	Lo que sucede es que se toma a la cadena de forma literal, es decir, no se puede escapar ningún carácter dentro de la cadena (las secuencias de escape se leen de forma literal).

### Punto 5:
* ***¿Que son y como funcionan las expresiones regulares?***  
	Una expresión regular es una secuencia de caracteres que define un patrón de búsqueda o reconocimiento sobre un texto.	
* ***¿Funcionan únicamente en C#?***  
	Las expresiones regulares no funcionan solamente en C#, de hecho funcionan en la mayoria de los lenguajes modernos.
* ***¿En qué casos le parecen útiles? Enuncie al menos 3.***  
	1. Son bastante utiles para definir la forma que debería tener un campo del estilo de una dirección web o un mail, proporcionan una manera sencilla de validar los mismos.
	2. Para reemplazar ocurrencias de una o mas palabras en un texto.
	3. Para encontrar ocurrencias de palabras en una gran cantidad de texto, como por ejemplo, cuando presionamos ctrl+f, el buscador del editor de texto podría buscar la palabra o secuencia de escape indicada mediante expresiones regulares (Visual Studio te da la opción de hacerlo).
* ***¿Cómo se hace uso de estas en C#?***  
	C# nos proporciona una librería llamada System.Text.RegularExpressions, la cual nos permite acceder a muchos métodos para trabajar con expresiones regulares mediante la clase Regex.  
	Definimos el patron que deseemos identificar en algún texto y luego declaramos un objeto del tipo Regex.  
		 Regex miRegex = new Regex(patron);  
	Luego, podemos hacer uso de los métodos de la clase para poder realizar la busqueda del patron ingresado en el texto. Por ej:  
		 miRegex.Matches(texto); //Buscamos ocurrencias del patron dentro del texto
