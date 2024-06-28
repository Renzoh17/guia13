Algoritmo Correo
	Definir i,codPostM,tipoEnvio,cantCartars,codPostal,condicion,empresaMayor como entero;
	Definir pesoMayor,mayor,peso,costoBase,costoIva,costoTotal,recTotal,recMayor Como Real;
	pesomayor<-0;		
	recMayor<-0;
	mayor<-0;
	codPostM<-0;
	recTotal<-0;	
	Para i<-1 Hasta 4 Con Paso 1 Hacer
		Escribir "Empresa ",i;
		Escribir "ingrese -1 para dejar de cargar datos, si no presione enter";
		Leer condicion;
		cantCartars<-0;
		
		Mientras condicion<>-1 Hacer
			
			cantCartars<-cantCartars+1;
			Escribir "Ingrese el peso de la carta en gramos y el codigo postal";
			Leer peso,codPostal;
			Escribir "Ingrese 1 si es simple y 2 si es cetificado";
			Leer tipoEnvio;
			Si tipoEnvio==1 Entonces
				costoBase<-0.50*peso;
			SiNo
				costoBase<-1*peso;
			Finsi
			costoIva<-(21/100)*costoBase;
			costoTotal<-costoBase+costoIva;
			Escribir "Costo Base:",costoBase,"Costo con IVA:",costoIva,"Costo Total:",costoTotal;
			Si mayor<costoTotal Entonces
				mayor<-costoTotal;
				pesoMayor<-peso;
				codPostM<-codPostal;
				
			Fin Si
			recTotal<-recTotal+costoTotal;
			Escribir "Ingrese -1 para terminar de cargar cartas,si no ingrese otro numero";
			Leer condicion;
		Fin Mientras
		Escribir "La cantidad de correspondencia recibida es:",cantCartars,"La carta de mayor costo es de :$",mayor," pesó:",pesoMayor,"gr y su codigo postal es:",codPostM;
		Escribir "La recaudación total es de: $",recTotal;
		Si recMayor<recTotal Entonces
			recMayor<-recTotal;
			empresaMayor<-i;
		Fin Si
	Fin Para
	Escribir "La empresa con mayor recaudación recaudación es la empresa ",empresaMayor," y recaudó $",recMayor;
FinAlgoritmo

