Proceso ejercicio06
	//En un supermercado se hace una promoci�n, mediante la cual el cliente obtiene un descuento 
	//dependiendo de un n�mero que se escoge al azar. Si el numero escogido es menor que 74 el 
	//descuento es del 15% sobre el total de la compra, si es mayor o igual a 74 el descuento es del 20%. 
	//Obtener cu�nto dinero se le descuenta.
	
	//declaracion de variables
	Definir numazar, valorcompra, descuento, totalpagar Como Real;
	//salida
	Escribir "digite el valor total de su compra";
	Leer valorcompra;
	numazar = azar(100);
	Escribir "el numero al azar asignado es",numazar;
	//Proceso 
	descuento = valorcompra * 0.10;
	si numazar >= 74 Entonces
		descuento = valorcompra * 0.20;
	FinSi
	totalpagar = valorcompra - descuento;
	
	Escribir "su descuento es de" , descuento , "y su total a pagar es" , totalpagar;

	
FinProceso
