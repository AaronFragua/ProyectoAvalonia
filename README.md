<h1>ProyectoAvalonia</h1> 
<h3>Pequeño proyecto en C# que utiliza la interfaz de usuario de Avalonia. </h3>
<h4 align="justify">Para ello, se quiere emular una tienda de reparaciones de dispositivos. En ella, se distinguen los tipos de aparatos para su reparación: Radios, Televisores, Reproductores de DVD y adaptadores de TDT, cada uno con su tarifa de reparación por hora (5, 10, 10 y 5 euros, respectivamente). De todos los aparatos se guarda su nº de serie, su modelo y su precio de reparación por hora. </br></br>De las radios se guardan las bandas que es capaz de manejar (AM/FM o ambas), de los televisores sus pulgadas, de los reproductores de DVD si reproducen Blue-Ray y también si graban o no, y en su caso el tiempo de grabación. Finalmente, de los adaptadores de TDT el tiempo máximo de grabación, si es que la soportan. </br>Una reparación toma el precio por horas para el aparato, y lo aplica en segmentos de una hora, haciendo la oportuna conversión. Si la reparación lleva una hora o menos, se considera sustitución de piezas, y se respeta el precio por hora estipulado para el aparato. En caso de superar la hora, entonces se trata de una reparación compleja, y se cobra aplicando un sobreprecio del 25% a los precios por hora trabajada asignados para cada aparato. Todas las reparaciones tienen un precio base de 10€, y el precio de las piezas se cobra aparte de las horas trabajadas. </h4>
</br></br>

<p align="left">
    <img src="https://github.com/user-attachments/assets/9781c26a-21f3-4668-b710-0c467864e276" width: 550px; align="left"; style="margin-right: 10px;" />
   
  <p align="justify">
  En la imagen de la izquierda podemos ver como se muestra el menú principal de la interfaz de usuario en primer momento, es decir, antes de seleccionar el tipo de dispositivo objeto de la reparación. En este caso, se pide al usuario que introduzca el número de serie del dispositivo y el modelo, ya que son características comunes de todos los dispositivos, por lo que siempre serán solicitados y de introducción obligatoria. Algo similar ocurre con tiempo de reparación y costo de las piezas, ya que siempre que introduzcamos una reparación de la cual queramos calcular su precio total, debemos indicar cuanto tiempo nos ha llevado y cuando han costado las piezas nuevas que hemos sustituído en el dispositivo, independientemente de cual sea el tipo del dispositivo objeto de la reparación.</br></br>
  Por otra parte, en las cuatro imágenes inferiores, podemos ver como el menú cambia para cada caso, es decir, si introducimos Radio como dispositivo a arreglar, se nos desplegará un nuevo campo (en este caso bandas), en el que podremos introducir las bandas que pueda sintonizar la radio (AM/FM o AMBAS).En caso de que el dispositivo introducido sea un televisor, se nos desplegará el campo pulgadas, si es un DVD se nos desplegarán si soporta BlueRay y el tiempo de grabación en minutos y si es el caso del TDT, el tiempo máximo de grabación.
  </p>



</br></br>
<div style="display: flex; gap: 10px;">
  <img src="https://github.com/user-attachments/assets/2e1dd1da-10f4-4766-a515-a46cf11f03b5" style="width: 245px;">
  <img src="https://github.com/user-attachments/assets/b0dd231d-d56d-42f9-9eb4-20c68167d768" style="width: 245px;">
  <img src="https://github.com/user-attachments/assets/be50c845-8990-4356-b1bc-9d230fc4b20a" style="width: 245px;">
  <img src="https://github.com/user-attachments/assets/723c32d4-18f6-4262-a6cc-55250119c92f" style="width: 245px;">
</div>

<p align="justify">
    Una vez introducidos los parámetros de la reparación que queremos tasar; tanto los del dispositivo a reparar como los de la propia reparación, simplemente tenemos que pulsar el botón de calcular precio, el cual llamará a la función que devuelve el precio de la reparación según haya sido simple, compleja, el tipo de dispositivo a reparar y el precio total de las piezas de sustitución. Podemos ver algunos casos de uso en las siguientes imágenes, las cuales son dos casos de éxito y dos errores con sus respectivos mensajes al usuario:</br></br>
</p>
<div style="display: flex; gap: 10px;">
  <img src="https://github.com/user-attachments/assets/40fde277-d631-4af6-94ae-adec0c14ddac" style="width: 245px;">
  <img src="https://github.com/user-attachments/assets/04324724-180a-4651-a826-d15cd379bbe6" style="width: 245px;">
  <img src="https://github.com/user-attachments/assets/041ae43e-c6d7-49bb-ba5e-439f9b55ca84" style="width: 245px;">
  <img src="https://github.com/user-attachments/assets/af05de2d-9787-422b-ac58-925c5c39c87a" style="width: 245px;">
</div>


