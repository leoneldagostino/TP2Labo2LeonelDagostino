
# Sistema hotelero 

## Trabajo laboratorio - Leonel E. D'agostino

En este sistema se puede usar para la creacion, asignacion y baja de un huesped que llega al hotel o se realiza la reserva de una habitacion para el o su familia.

Cuenta tambien con una apartado donde puede consultar sobre habitaciones que se encuentran disponibles o buscar sobre algun huesped en particular con su dni.

Este sistema tambien tiene un login donde aca entraran los administradores que se encarguen de hacer las distinas gestiones en el hotel, bastara con iniciar sesion por medio de usuario y contraseña.  

## Tecnologias 

- C#
- SQL

## Librerias

- Font Awesome

## Funcionalidades y su codigo

### HOME
![](https://i.imgur.com/T7qMElx.png)
En esta seccion es un mini menu donde se encuentran accesos rapido hacia donde se puede ir 


### Asignacion de huespued
![](https://i.imgur.com/XUVsTjV.png)
En esta seccion es donde al buscar el huesped registrado previamente se le asignara una habitacion segun su requerimientos, caso de que no haya cupo se notificara, como tambien se notificara cuando se asigne con exito

### Recepcion
![](https://i.imgur.com/xLXrKBX.png)
En esta parte se realizara la recepcion del huesped tomando los datos correspondientes 

### Registros
![](https://i.imgur.com/SHXLYID.png)
En esta parte se mostrara los cupos disponibles, buscar un huesped por su dni o directamente buscar que habitaciones se encuentran disponibles


### Salida de huespues
![](https://i.imgur.com/SXdM0HJ.png)
En esta seccion se ingresara el dni del huesped que va realizar la salida del hotel

### Conifrmacion de salida huesped
![](https://i.imgur.com/PsBen8r.png)
En esta parte se confirma la salida del huesped del cual se muestran los datos que se tienen del huesped

### Login 
![](https://i.imgur.com/lLEymeB.png)
En esta seccion es donde el empleado ingresa al sistema, teniendo que ingresar su usuario y contraseña.

## Codigo
### Seccion registro
![Seccion Registro](https://i.imgur.com/dYqFu28.png)
En este parte del codigo se implementa el uso de task.run para abrir un hilo donde va hacer la registracion en la base de datos tomando los distintos datos , tambien se utiliza manejo de excepciones

![Seccion Registro](https://i.imgur.com/KshoUIv.png)
En esta parte del codigo se observa la subcripcion al evento de manejarHuespedRegistrado

![Seccion Registro](https://i.imgur.com/TsS6FL5.png)
Aca se observa el manejo de excepciones que cuando se capturen mostrara un cartel mostrar el error ocurrido

![Seccion Registo](https://i.imgur.com/XVypgMn.png)
En este codigo es la creacion del evento para manejar si un usuario se registra, lanzando un mensaje en caso de exito

### Codigo Repositorio huesped
![Seccion Repositorio Huesped](https://i.imgur.com/j0Ngq7i.png)
Aqui se observa la declaracion de los delegados y creacion de los eventos con la firma de los delegados e tambein la implementacion de Interfaces que son de tipo generica



![Seccion Repositorio Huesped](https://i.imgur.com/D9vCY8X.png)
En esta parte es se observa que el metodo retorna una lista de los huespedes que obtiene mediante la consulta a la base de datos 

![Seccion Repositorio Huesped](https://i.imgur.com/c1Ry3iU.png)
Estos metodos son las invocaciones a los eventos correspondientes a cada accion que se busca con los huespedes

![Seccion Repositorio Huesped](https://i.imgur.com/T4g2pch.png)
En este metodo de la seccion de repositorio de huesped realiza la busqueda del huesped por su dni, en caso de encontrarlo invocara al metodo que lanza el evento notificando que se encontro el huesped

### Pruebas Unitarias 
![Pruebas Unitarias](https://i.imgur.com/RLnR9T3.png)
Aca se ve las distinas muestras que se utilizan



