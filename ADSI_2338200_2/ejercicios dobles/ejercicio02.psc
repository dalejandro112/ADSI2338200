Proceso ejercicio02
	//Un obrero necesita calcular su salario semanal, el cual se obtiene de la sig. manera:
	//? Si trabaja 40 horas o menos se le paga $16 por hora
	//? Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20 por cada hora 
	//extra.
	
	//definir variable 
	Definir horas, total, horas_extras, total_pagar Como Real;
	
	//salida
	Escribir "escribir el numero de horas que trabajo en la semana ";
	Leer horas;
	
	//Proceso 
	
	si (horas > 40) Entonces
		horas_extras <- (horas - 40) * 20;
		total_pagar  <- horas_extras + (40 * 16);
		Escribir "su total a pagar es de", total_pagar, "$, incluidas las horas extra,";
	SiNo
		total_pagar <- horas * 16;
		Escribir "su total a oagar es de", total_pagar,"$.";
	FinSi
FinProceso
