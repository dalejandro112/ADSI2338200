// ENTRADA: Cuando la entrada gratis se halla dado  se convierte en true    

let free = false;

const validarCliente = (time) =>{
    let edad = prompt(" ¿Cual es tu edad? ");
    if(edad > 18){
        if(time >= 2 && time < 7 && free == false){
            alert("No pagas, puedes pasar porque eres la primera persona despues de las 2 am")  
            free = true; // Ahora cuando se vuelva a ejecutar por segunda vez no dejara a nadie pasar GRATIS (ya que el problema solo dice que la primera persona despues de las 2 am)
        }else{
            alert(`Puedes pasar, tienes que pagar. Son las ${time}:00Hs`)  
        }                             
    }else {
        alert("No puedes pasar")
    }
}

validarCliente(23);
validarCliente(24);
validarCliente(0.2);
validarCliente(0.6);
validarCliente(1);
validarCliente(2);
validarCliente(2.4);
validarCliente(3);