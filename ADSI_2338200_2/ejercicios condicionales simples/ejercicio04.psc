Proceso ejercicio04
	//Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con 
	//descuento. El descuento lo hace en base a la clave, si la clave es 1 el descuento es del 10% y si la 
	//clave es 2 el descuento en del 20% (solo existen dos claves).
	
	//declaracion de variables 
	Definir nombre como cadena;
	Definir clave,preciO,preciD,preciT	Como Real;
	
	//salida
	Escribir "escriba el nombre del producto";
	Leer nombre;
	Escribir "escriba el valor del producto";
	Leer preciO;
	Escribir "escriba la clave del producto que puede ser 1 o 2";
	Leer clave;
	Mientras (clave<>1 y clave<>2) Hacer
		Escribir "-la clave no es valida, vuelva a ingresar el valor";
		Escribir "-escriba la clave del producto que puede ser 1 o 2";
		Leer clave;
	FinMientras
	
	//Proceso 
	preciD=preciO*0.10;
	
	si(clave==2) Entonces
		preciD=preciO*0.20;
	FinSi
	preciT=preciO-preciD;
	Escribir "el nombre del articulo es" ,nombre, "la clave es" ,clave, "el precio original es" ,preciO, "y su total a pagar con descuento es" ,preciT,;
FinProceso
