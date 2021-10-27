Proceso ejercicio04
	//Una empresa de bienes raíces ofrece casas de interés social, bajo las siguientes condiciones: Si los ingresos del 
	//comprador son mayores o iguales a $800000 la cuota inicial será del 15% del costo de la casa y el resto se 
	//distribuirá en pagos mensuales, a pagar en diez años. Si los ingresos del comprador son inferiores a de $800000 
	//la cuota inicial será del 30% del costo de la casa y el resto se distribuirá en pagos mensuales a pagar en 7 años.
	//La empresa quiere saber cuanto debe pagar un comprador por concepto de cuota inicial y cuanto por cada 
	//pago mensual ingresando el valor de la casa.
	
	//definir variable 
	Definir  valor_casa,salario,cuota,pagar_mensual Como Real;
	
	//salida
	Escribir "escriba el valor de la casa";
	Leer valor_casa;
	Escribir "escribir sus ingresos mensuales";
	Leer salario;
	
	//Proceso 
	si(salario>=800000) Entonces
		cuota=valor_casa*0.15;
		pagar_mensual=valor_casa-valor_casa*0.15/120;
	SiNo
		cuota=valor_casa*0.30;
		pagar_mensual=valor_casa-cuota/84;
		
	FinSi
	Escribir "su cuota inicial es de $",cuota,"pesos y su pago mensual es de $",pagar_mensual,"pesos";
	
	
FinProceso
