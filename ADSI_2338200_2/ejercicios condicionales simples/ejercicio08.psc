Proceso ejercicio08
	
	//. Dada la duración en minutos de una llamada calcular el costo, considerando 
	// Hasta tres minutos el costo es 600
	//Por encima de tres minutos es 600 más 150 por cada minuto adicional a los tres primeros.
	
	//declaracin de variables 
	Definir time_call,costo_minuto,costo_llamada,minutos_extra Como Real;
	//salida
	Escribir "cuanto duro la llamada";
	Leer time_call;
	costo_minuto=200;
	costo_llamada=costo_minuto*time_call;
	//Proceso 
	si (time_call>3) Entonces
		minutos_extra=(timne_call-3)*150;
		costo_llamada=costo_llamada+costo_minuto;
		Escribir "el costo de los minutos extra fueron" ,minutos_extra;
	FinSi
	Escribir "su llamada duro" ,time_call, "minutos","|"," el costo de esta llamada es: ",costo_llamada;
	
FinProceso
