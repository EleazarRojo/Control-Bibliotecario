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

### Ayuda
No hay Ayuda

### Registrar 
Si un usuario de la aplicación no cuenta con un Id de Usuario para utilizar las funciones que brinda el Sistema de Control Bibliotecario este podrá realizar un auto registro a través del Módulo de registrarse el cuál solicita Datos generales de la persona que desea incorporarse al sistema bibliotecario, después de llenar los campos correspondientes con el uso del botón **Registrar** se completará el proceso de registró y obtendrá su Id de Usuario con éxito.

### Ingresar

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
En el inventario de Libros se le muestra al Bibliotecario un despliegue de todos los libros que se encuentran actualmente en la Biblioteca, en cada registro de los libros se muestra la información revelante
sobre cada libro, como titulo, autor, número de edición, año, tema y el estado de prestamo en el que se encuentra cada Libro.

Dentro del inventario de libros el bibliotecario es capaz de buscar los libros por los siguientes citerios: 

* ISBN
* Título
* Autor
* Tema
* Año

Además en el apartado de Tipo de Búsqueda se agregan dos operaciones adicionales: **Modificación de Libros y Eliminación de Libros**

Para la **Modificiación** de libros es necesario primeramente buscar el libro que se deasea modificar por su ID de Copia, una vez encontrado el libro se despliegan los datos obtenidos del libro encontrado
y se pueden editar para realizar las modificaciones correspondientes, después de haber terminado los cambios correspondientes se confirman los cambios con el boton de **Modificar Libro**.

Para la **Eliminación** de libros es necesario primeramente buscar el libro que sea desea eliminar por su ID de Copia, una vez encontrado el libro se habilitará el botón de **Eliminar Libro**  el cuál al presionarse se hará la eliminación correspondiente con el libro que se encontró en la búsqueda anteriormente realizada.

  (Explicar los Modulos de Bibliotecario)
<p align="center">
  <b>Modulos de Bibliotecario</b>
  <img src = "">
</p>

  ### Administradores 
  + **Administrador**: Los usuarios de nivel Administradorn tendran que ingresar su ID de Usuario en el apartado de Ingresas. Despues de presionar el bontón ingresar, se iniciara otra ventana de ingreso de empleados donde se le pedira la contraseña al usuario para poder iniciar sesión

#### Control de Usuarios
En el módulo de Control de Usuarios se le muestra a Administrador un registro de todos los usuarios actualmente registrados con sus datos generales y su ID de Usuario Correspondiente, en la parte inferior 
del módulo se le permite al administrador realizar búsquedas de usuarios por los siguientes criterios: 

* Id de Usuario
* RFC

Además de las 2 operaciones adicionales de **Modificación  y Eliminación de Usuario** 


##### Registrar Usuario y Colaborador
En los módulos de **Registrar Usuario y Registrar Colaborador** que se enucentran en le menú situado en la parte superior de la ventana, el administrador es capaz de dar de alta *usuarios de acceso general* 
en el módulo de **Registrar Usuario** y registrar usuarios con nivel acceso de **Administrador y Bibliotecario** en el Módulo de Registrar Colaborador, llenando los campos correspondientes que se solicitan que son datos generales de la persona a registrar.


##### Modificar Usuario
Para la **Modificiación** de usuarios es necesario primeramente buscar el usuario que se deasea modificar por su ID de Usuario, una vez encontrado el usuario se despliegan los datos obtenidos del usuario encontrado y se pueden editar para realizar las modificaciones correspondientes, después de haber terminado los cambios correspondientes se confirman los cambios con el boton de **Aceptar Modificación**.

##### Eliminar Usuario
Para la **Eliminación** de Usuarios es necesario primeramente buscar el Usuario que sea desea eliminar por su ID de Usuario, una vez encontrado el Usuario se habilitará el botón de **Eliminar Usuario**  el cuál al presionarse se hará la eliminación correspondiente con el Usuario que se encontró en la búsqueda anteriormente realizada.








