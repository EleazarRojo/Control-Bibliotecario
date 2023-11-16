# Control-Bibliotecario
Proyecto TAP 2023 S3B Sistema de control bibliotecario
Elaborado por: 
* Carlos Arturo Ojeda Bernal
* Eleazar Rojo Romero
* Cesar Alejandro Soto Belmonte
---

La presente aplicación es un sistema de control Bibliotecario que simula su implementación dentro de una biblioteca.

En la aplicación podemos encontrar una variedad de módulos que dependiendo del tipo de usuario son capaces de interacturar con uno o más de ellos
* Ingreso de Usuarios
* Registro de Usuarios
* Control de Usuarios
* Consulta de Libros
* Inventario de Libros
* Realizar Prestamos
* Devolución de Prestamos
* Historial de Prestamos

Podemos encontrar los siguientes Tipos de Usuarios y los **módulos** a los que tienen acceso:
* Usuarios generales
  + Autoregistro
  + Ingreso de Usuario
  + Búsqueda de Libros
  + Historial de Prestamos
    
* Administradores
   + Igreso de Administrador
   + Registro de Usuarios
   + Control de Usuarios
   + Consulta de Libros
   + Inventario de Libros
   + Realización de Prestamos
   + Devolución de Prestamos
   + Historial de Prestamos
  
* Bibliotecarios
  + Ingreso de Colaborador
  + Consulta de Libros
  + Inventario de Libros
  + Realización de Prestamos
  + Devolución de Prestamos
  + Historial de Presamos

## Menú Principal 
En este módulo podemos encontrar principalmente la funcionalidad de Búsqueda de libros, En el se despliegan una lista de libros previamente cargados en la base
de datos como titulos de prueba. La principal funcionalidad es poder realizar consultas sobre la existencia y disponibilidad de los libros dando la opción de realizar
la búsqueda por los siguientes criterios: 

* ISBN
* Título
* Autor
* Tema
* Año

En la parte superior del Menú Principal se encuentra 3 Módulos: **Ingresar, Registrarse y Ayuda** 
<p align="center">
  <img src = "https://user-images.githubusercontent.com/134666855/283604804-e6a09a0e-44c3-4a92-97e5-4af7046ef917.png">
</p>

* Ingresar

<p align="center">
  <img src = "https://user-images.githubusercontent.com/134666855/283602550-6ce511de-99e5-45ce-a399-b7a0c43754ed.png">
</p>

  Es la primera opción del Menú. Es necesario de realizar un solo click sobre la opción para que se despliegue una nueva ventana donde el usuario iniciara sesión.

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/6d448699-653b-405d-ac17-14ba29a8a563">
</p>

  Para iniciar sesión se requiere de el ID de Usuario, el cual fue proporcianado al momento de registrarse. Existen dos casos de Inicio de Sesión: **Usuarios** y **Empleados: Administrador o Bibliotecario**
### Usuarios
  + **Usuarios**: Los usuarios solo requieren de su ID de Usuario para ingresar a su perfil. 

<p align="center">
  <b>Perfil de Usuario</b>
  <img src = "">
</p>

  Al haber ingresado exitosamente, el usuario sera devuelto al Menú principal pero ahora el Menú desplegará el nombre del Usuario y le dará acceso a su historial de prestamos.
#### Historial de Prestamos
En el historial de prestamos se despliagan todos los prestamos realizados por el Usuario ingresado, en el se le da a conocer la información sobre los datos generales del libro
que se prestó, así como el estado en el que se encuentra dicho prestamo. Los estados que un prestamo puede tomar son: **Activo, Devuelto y Vencido**


<p align="center">
  <b>Modulos de Usuarios</b>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/90274181/ebebbac8-98aa-43ff-b7d0-85fa79f2bd57">
</p>



  ### Bibliotecarios
  
  + **Bibliotecario**: Los usuarios de nivel Bibliotecario tendran que ingresar su ID de Usuario de la misma manera. Despues de presionar el boton ingresar, se iniciara otra ventana donde se le pidira la contraseña al usuario para poder iniciar sesión.

<p align="center">
  <b>Perfil de Bibliotecario</b>
  <br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/6d448699-653b-405d-ac17-14ba29a8a563">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/9b9cd7ca-3924-48c3-aacf-0ff8d2b65992">
  <br><br>
</p>

#### Control de Prestamos
En el control de Prestamos nos podemos encontrar con un historial de todos los prestamos que se han realizado por todos los usuarios, desplegando la información sobre cada uno de ellos,
de esta forma el bibliotecario puede tener un control del estatus de cada prestamo, ya sea activo, devuelto o vencido y actuar correspondidamente dependiendo del estatus. Además podemos encontrar en el 
menú de la parte superior dos módulos: **Realizar Prestamo y Devolver Prestamo**

##### Realizar Prestamo
En el módulo de relizar prestamo se le presenta al bibliotecario un lista de todos los libros actualmente disponibles los cuáles pueden ser prestados a los usuarios. La forma de realizar un prestamo es atreaves de una búsqueda previa del libro por su ISBN, donde se desplegaran las copias disponibles del libro encontrado, seguido se selecciona la copia del libro a ser prestado y el Id del Usuario quien está solicitado el Libro, para finalizar se útiliza el botón de **Realizar Prestamo** y si los datos están correctos el prestamo será realizado con exito actualizando el despliegue de los libros disponibles. 

##### Devolver Prestamo
En el módulo de devolver prestamo se le presenta al bibliotecario el despligue de todos los prestamos activos o vencidos de los usuarios los cuáles pueden ser devueltos. EL bibliotecario buscará el prestamo 
activo con el Id de usuario del usuario quien solicita la devolución del prestamo, con el botón de **Buscar Prestamo** si se encunetra un prestamo válido para su devolución con el Id de usuario ingresado se 
desplegará la información general del prestamo y con el botón de **Devolver Prestamo** el prestamó será devuelto y el estatus pasará de *Activo o Vencido* a **Devuelto**

#### Inventario de Libros

  (Explicar los Modulos de Bibliotecario)
<p align="center">
  <b>Modulos de Bibliotecario</b>
  <img src = "">
</p>

  ### Administradores 
  + **Administrador**: Los usuarios de nivel Administradorn tendran que ingresar su ID de Usuario en el apartado de Ingresas. Despues de presionar el bontón ingresar, se iniciara otra ventana de ingreso de empleados donde se le pedira la contraseña al usuario para poder iniciar sesión

#### Control de Usuarios

##### Registrar Usuario

##### Registrar Colaborador

##### Modificar Usuario

##### Eliminar Usuario


* Registrarse
* Ayuda







