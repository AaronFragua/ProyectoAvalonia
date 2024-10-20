<h1>ProyectoAvalonia</h1> 
<h3>Pequeño proyecto en C# que utiliza la interfaz de usuario de Avalonia. </h3>
<h4 align="justify">Para ello, se quiere emular una tienda de reparaciones de dispositivos. En ella, se distinguen los tipos de aparatos para su reparación: Radios, Televisores, Reproductores de DVD y adaptadores de TDT, cada uno con su tarifa de reparación por hora (5, 10, 10 y 5 euros, respectivamente). De todos los aparatos se guarda su nº de serie, su modelo y su precio de reparación por hora. </br></br>De las radios se guardan las bandas que es capaz de manejar (AM/FM o ambas), de los televisores sus pulgadas, de los reproductores de DVD si reproducen Blue-Ray y también si graban o no, y en su caso el tiempo de grabación. Finalmente, de los adaptadores de TDT el tiempo máximo de grabación, si es que la soportan. </br></br>Una reparación toma el precio por horas para el aparato, y lo aplica en segmentos de una hora, haciendo la oportuna conversión. Si la reparación lleva una hora o menos, se considera sustitución de piezas, y se respeta el precio por hora estipulado para el aparato. En caso de superar la hora, entonces se trata de una reparación compleja, y se cobra aplicando un sobreprecio del 25% a los precios por hora trabajada asignados para cada aparato. Todas las reparaciones tienen un precio base de 10€, y el precio de las piezas se cobra aparte de las horas trabajadas. </h4>
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

<h2><b>CLASES</b>
</h2>
<h3><b></b>Dispositivo.cs</b>
</h3>
<h4 align="justify">La superclase Dispositivo.cs es creada con la finalidad de contener los atributos comunes de todos los dispositivos que puedan ser reparados en nuestro sistema. Así pues, tiene 4 atributos:</br></br>
  - NumeroSerie de tipo int.</br>
  - Modelo de tipo String.</br>
  - PrecioReparacionPorHora de tipo int.</br>
  - Tipo de tipo TipoDispositivo, que es un enumerado que solo puede tomar los valores Radio, TV, DVD y TDT.</br></br>
  Además, cuenta con un constructor que recibe como parametros los valores que pasaremos a esos cuatro atributos, un método getNumeroSerie, que devuelve el numero de serie y otro getTipoDispositivo que devuelve el tipo del dispositivo. Estas funciones serían innecesarias por dos motivos: los atributos son públicos y estas funciones no se usan en este proyecto. La razón de incluirlas es que se tiene pensado modificar en un futuro para poner los atributos privados y hacer uso de estas funciones, por lo que el dejarlas hechas agiliza el trámite de modificación que se prevee para un futuro próximo.
</h4>

<h3><b>TV.cs</b>
</h3>
<h4 align="justify">La subclase TV.cs hereda de la superclase Dispositivo.cs y se crea con la finalidad de poder instanciar las distintas TV´s que se arreglen en el sistema. Al heredar de la superclase Dispositivo, hereda los cuatro atributos que comentamos anteriormente, además de contar con uno nuevo:</br></br>
  - Pulgadas de tipo int.</br></br>
  Además, cuenta con un constructor que recibe como parametros los valores que pasaremos a este atributos y a los otros cuatro que hereda de la clase Dispositivo.
</h4>

<h3><b>TDT.cs</b>
</h3>
<h4 align="justify">La subclase TDT.cs hereda de la superclase Dispositivo.cs y se crea con la finalidad de poder instanciar los distintos TDT´s que se arreglen en el sistema. Al heredar de la superclase Dispositivo, hereda los cuatro atributos que comentamos anteriormente, además de contar con uno nuevo:</br></br>
  - TiempoGrabacion de tipo int.</br>
  - PuedeGrabar de tipo booleano</br></br>
  Además, cuenta con un constructor que recibe como parametros el valor que pasaremos al atributo TiempoGrabacion (que nos sirve para instanciar también el atributo PuedeGrabar al otorgar el valor TiempoGrabacion>0 a este atributo) y a los otros cuatro que hereda de la clase Dispositivo.
</h4>

<h3><b>DVD.cs</b>
</h3>
<h4 align="justify">La subclase DVD.cs hereda de la superclase Dispositivo.cs y se crea con la finalidad de poder instanciar los distintos DVD´s que se arreglen en el sistema. Al heredar de la superclase Dispositivo, hereda los cuatro atributos que comentamos anteriormente, además de contar con uno nuevo:</br></br>
  - TiempoGrabacion de tipo int.</br>
  - PuedeGrabar de tipo booleano.</br>
  - BlueRay de tipo booleano.</br></br>
  Además, cuenta con un constructor que recibe como parametros los valores que pasaremos a los atributos TiempoGrabacion (que nos permitirá inicializar el valor de PuedeGrabar de forma análoga a como lo hacíamos en la clase TDT) y BlueRay y a los otros cuatro que hereda de la clase Dispositivo.
</h4>

<h3><b>Radio.cs</b>
</h3>
<h4 align="justify">La subclase Radio.cs hereda de la superclase Dispositivo.cs y se crea con la finalidad de poder instanciar las distintas Radios que se arreglen en el sistema. Al heredar de la superclase Dispositivo, hereda los cuatro atributos que comentamos anteriormente, además de contar con uno nuevo:</br></br>
  - MiBandas de tipo Bandas, que es un enumerado que puede tomar los valores AM, FM o AMBAS.</br></br>
  Además, cuenta con un constructor que recibe como parametros el valor que pasaremos a este atributo y a los otros cuatro que hereda de la clase Dispositivo.
</h4>

<h3><b></b>Reparacion.cs</b>
</h3>
<h4 align="justify">La superclase Reparacion.cs es creada con la finalidad de contener los atributos comunes de todas las reparaciones que puedan tener lugar en nuestro sistema. Así pues, tiene 3 atributos:</br></br>
  - MiDispositivo de tipo Dispositivo.</br>
  - TiempoReparacion de tipo int</br>
  - PrecioPiezas de tipo double</br></br>
  Además, cuenta con un constructor que recibe como parametros los valores que pasaremos a esos tres atributos y una función CalcularPrecioReparacion que es abstracta y será implementada en las dos subclases que hereden de esta superclase.
</h4>

<h3><b></b>ReparacionSimple.cs</b>
</h3>
<h4 align="justify">La subclase ReparacionSimple.cs hereda de la superclase Reparacion.cs y es creada con la finalidad de implementar la función CalcularPrecioReparacion que en la superclase definimos como abstracta.</br></br>
  Cuenta con un constructor que recibe como parametros los valores que otorgaremos a los atributos que heredamos de la superclase. Además, implementa la función ya comentada siguiendo la fórmula que nos dicta el enunciado expuesto en la parte de arriba de esta página.
</h4>

<h3><b></b>ReparacionCompleja.cs</b>
</h3>
<h4 align="justify">La subclase ReparacionCompleja.cs hereda de la superclase Reparacion.cs y es creada con la finalidad de implementar la función CalcularPrecioReparacion que en la superclase definimos como abstracta.</br></br>
  Cuenta con un constructor que recibe como parametros los valores que otorgaremos a los atributos que heredamos de la superclase. Además, implementa la función ya comentada siguiendo la fórmula que nos dicta el enunciado expuesto en la parte de arriba de esta página.
</h4></br></br>
<h2 align="justify">NOTA: Se podría implementar un atributo en la clase Reparacion.cs que discriminase en caso de que la Reparacion fuese simple o compleja y usarla en la función de la propia superclase, ahorrándonos así la implementación de ambas subclases, pero esta solución responde a un enunciado en el que es obligatorio implementar una jerarquía de clases tanto para los dispositivos como para las reparaciones, a pesar de que para un proyecto más optimizado, lo suyo sería hacerlo de la forma comentada.</h2></br></br>

<h3><b></b>MainWindow.axaml</b>
</h3>
<h4 align="justify">La clase MainWindow.cs contiene la creación de los objetos que se usarán en la clase MainWindow.axaml.cs. En esta clase definimos el botón de calcular precio de la reparación, los comboboxes que se desplegarán para las bandas de radio y para los tipos de dispositivos y las textboxes que se desplegarán para los demás campos a rellenar, además de dejar visibles los campos que se rellenarán siempre y ocultar los que son propios de cada dispositivo para que en la lógica de la clase MainWindow.axaml.cs se muestren cuando elijamos el dispositivo objeto de la reparación.</br></br></h4>

<h3><b></b>MainWindow.axaml.cs</b>
</h3>
<h4 align="justify">La clase MainWindow.axaml.cs contiene toda la lógica del front, es decir, en ella se carga el formulario, el botón de calcular precio de la reparación y sacarlo por pantalla para que lo vea el usuario, se comprueba que los valores introducidos en los campos sean correctos (cumplan el formato) y en caso contrario se enseña por pantalla un mensaje de error como hemos visto en los ejemplos anteriores, se crea el dispositivo y la reparación con los datos introducidos y se llama a la función para calcular el precio de la reparación en función de si se trata de una reparación simple o compleja. Además, esta clase también se encarga de ocultar o enseñar la petición de los distintos campos según el tipo de dispositivo que se haya introducido.</br></br></h4>

