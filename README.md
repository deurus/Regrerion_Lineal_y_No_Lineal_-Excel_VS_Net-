# Regrerion_Lineal_y_No_Lineal_-Excel_VS_Net-
REGRESIÓN LINEAL Y NO LINEAL – EXCEL VS .NET

<h2>Introducción</h2>
La ecuación de Antoine es utilizada para obtener el valor de la presión de vapor (P) en función de la temperatura (T) para componentes puros y se basa en una correlación de tres parámetros A, B y C. Dicho esto, el objetivo de esta entrada es obtener los coeficientes de la ecuación de Antoine para un rango de temperaturas y presiones concretos dada la siguiente ecuación.<br><br>

log(P)=A−B/(T+C)
​<br><br>
Para ello utilizaremos Excel como herramienta básica que casi todos conoceréis y tendréis instalada en vuestro equipo y además veremos como afrontar este tipo de problemas en .NET con la ayuda de una librería externa bastante interesante como es Accord. No es la intención de esta entrada profundizar en conceptos matemáticos complejos ni entrar en detalle en el concepto de regresión, más bien se pretende dar unas pinceladas para poder ser capaces de plantear y resolver problemas similares.<br><br>

| **Temperatura (ºF)** | **Presión (psia)** |
| -------------------- | ------------------ |
| 65,44                | 41,17              |
| 73,78                | 47,32              |
| 82,11                | 54,15              |
| 90,45                | 61,70              |
| 98,78                | 70,02              |
| 107,12               | 79,15              |
| 115,46               | 89,14              |
| 123,79               | 100,03             |
| 132,13               | 111,87             |
| 140,46               | 124,70             |
| 148,80               | 138,58             |
| 157,13               | 153,54             |
| 165,47               | 169,64             |
| 173,80               | 186,90             |
| 182,14               | 205,39             |

<h2>Excel Lineal</h2>

