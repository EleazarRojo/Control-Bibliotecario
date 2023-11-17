# Control-Bibliotecario
Proyecto TAP 2023 S3B Sistema de Control Bibliotecario

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

## Registrar 
Si un usuario de la aplicación no cuenta con un Id de Usuario para utilizar las funciones que brinda el Sistema de Control Bibliotecario este podrá realizar un auto registro a través del Módulo de registrarse el cuál solicita Datos generales de la persona que desea incorporarse al sistema bibliotecario, después de llenar los campos correspondientes con el uso del botón **Registrar** se completará el proceso de registró y obtendrá su Id de Usuario con éxito.

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/9fe0b650-b8a7-446f-9f5e-2658c194bcd6">
  <br>
</p>

## Ingresar

<p align="center">
  <img src = "https://user-images.githubusercontent.com/134666855/283602550-6ce511de-99e5-45ce-a399-b7a0c43754ed.png">
</p>

  Es la primera opción del Menú. Es necesario de realizar un solo click sobre la opción para que se despliegue una nueva ventana donde el usuario iniciará sesión.

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/6d448699-653b-405d-ac17-14ba29a8a563">
</p>

  Para iniciar sesión se requiere de el ID de Usuario, el cual fue proporcianado al momento de registrarse. Existen dos casos de Inicio de Sesión: **Usuarios** y **Empleados: Administrador o Bibliotecario**
## Usuarios
  + **Usuarios**: Los usuarios solo requieren de su ID de Usuario para ingresar a su perfil. 
<p align="center">
  <b>Verificación de Usuario</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/e066bb3c-b00c-4fe9-af64-a4fc7d539e4d">
  <br><br>
</p>

  Al haber ingresado exitosamente, el usuario sera devuelto al Menú principal pero ahora el Menú desplegará el nombre del Usuario y le dará acceso a su historial de prestamos.

<p align="center">
  <b>Perfil de Usuario</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/644c0cd3-5b74-4c3c-a17e-1b2772e44eb3">
  <br><br>
</p>

### Historial de Prestamos
En el historial de prestamos se despliagan todos los prestamos realizados por el Usuario ingresado, en el se le da a conocer la información sobre los datos generales del libro
que se prestó, así como el estado en el que se encuentra dicho prestamo. Los estados que un prestamo puede tomar son: **Activo, Devuelto y Vencido**


<p align="center">
  <b>Modulos de Usuarios</b>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/90274181/ebebbac8-98aa-43ff-b7d0-85fa79f2bd57">
</p>



## Bibliotecarios
  
  + **Bibliotecario**: Los usuarios de nivel Bibliotecario tendran que ingresar su ID de Usuario de la misma manera. Despues de presionar el boton ingresar, se iniciara otra ventana donde se le pidira la contraseña al usuario para poder iniciar sesión.

<p align="center">
  <b>Perfil de Bibliotecario</b>
  <br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/6d448699-653b-405d-ac17-14ba29a8a563"><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/9f6f02c4-36f9-42ef-904a-523a9abe3583">
  <br><br>
  <b>Modulos de Bibliotecario</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/f713fd47-18c4-4340-9d9e-d4cb27a4d75e">
  <br><br>
</p>

### Control de Prestamos
En el control de Prestamos nos podemos encontrar con un historial de todos los prestamos que se han realizado por todos los usuarios, desplegando la información sobre cada uno de ellos,
de esta forma el bibliotecario puede tener un control del estatus de cada prestamo, ya sea activo, devuelto o vencido y actuar correspondidamente dependiendo del estatus. Además podemos encontrar en el 
menú de la parte superior dos módulos: **Realizar Prestamo y Devolver Prestamo**

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/25b49537-d12a-40a6-978b-37d4865547a1"><br>
  <br>
  <b>Tipos de Busqueda</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/2015dd58-3ea0-41d9-b382-7b734d2b89b0">
  <br><br>
</p>

#### Realizar Prestamo
En el módulo de relizar prestamo se le presenta al bibliotecario un lista de todos los libros actualmente disponibles los cuáles pueden ser prestados a los usuarios. La forma de realizar un prestamo es atreaves de una búsqueda previa del libro por su ISBN, donde se desplegaran las copias disponibles del libro encontrado, seguido se selecciona la copia del libro a ser prestado y el Id del Usuario quien está solicitado el Libro, para finalizar se útiliza el botón de **Realizar Prestamo** y si los datos están correctos el prestamo será realizado con exito actualizando el despliegue de los libros disponibles. 

<p align="center">
  <b>Ventana</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/8c6a71ac-7add-41bb-be72-f8fc0b4c0191"><br>
  <br>
  <b>Proceso de Prestamo</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/bba8786e-dec3-4bb3-91e7-ffa1bd16e5e9">
  <br><br>
</p>

#### Devolver Prestamo
En el módulo de devolver prestamo se le presenta al bibliotecario el despligue de todos los prestamos activos o vencidos de los usuarios los cuáles pueden ser devueltos. EL bibliotecario buscará el prestamo 
activo con el Id de usuario del usuario quien solicita la devolución del prestamo, con el botón de **Buscar Prestamo** si se encunetra un prestamo válido para su devolución con el Id de usuario ingresado se 
desplegará la información general del prestamo y con el botón de **Devolver Prestamo** el prestamó será devuelto y el estatus pasará de *Activo o Vencido* a **Devuelto**

<p align="center">
  <b>Ventana</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/5b98c6bb-4167-43d2-86b8-15f410c32936"><br>
  <br>
  <b>Proceso de Devolución</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/bf704aa4-1c40-4318-b2b5-feceed450506">
  <br><br>
</p>

### Inventario de Libros
En el inventario de Libros se le muestra al Bibliotecario un despliegue de todos los libros que se encuentran actualmente en la Biblioteca, en cada registro de los libros se muestra la información revelante
sobre cada libro, como titulo, autor, número de edición, año, tema y el estado de prestamo en el que se encuentra cada Libro.

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/bff56a0a-294a-4270-b8be-c6a7e28c02d2">
</p>

Dentro del inventario de libros el bibliotecario es capaz de buscar los libros por los siguientes citerios: 

* ISBN
* Título
* Autor
* Tema
* Año

Además en el apartado de Tipo de Búsqueda se agregan dos operaciones adicionales: **Modificación de Libros y Eliminación de Libros**

<p align="center">
  <b>Tipos de Busqueda</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/64b517f9-3507-49af-95ce-03fbe7718e7b"><br>
</p>

Para el **Agregado** de un libro se requiere de selecionar la opcion de agregado como Tipo de Busqueda. Una vez selecionado, la ventana desplegara los campos necesarios para completar la información de un libro. Es necesario llenar todos los campos para agregar el libro exitosamente. Una vez llenas los campos se deberá precionar el boton de **Añadir Libro** el cual agregara a la base de datos el libro especificado. Ah este se le asignará un Id de Copia unico.

<p align="center">
  <b>Agregado de un Libro</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/b43ce64f-edac-4c8c-86d9-5cfa1d36380a"><br>
</p>

Para la **Modificiación** de libros es necesario primeramente buscar el libro que se deasea modificar por su ID de Copia, una vez encontrado el libro se despliegan los datos obtenidos del libro encontrado
y se pueden editar para realizar las modificaciones correspondientes, después de haber terminado los cambios correspondientes se confirman los cambios con el boton de **Modificar Libro**.

<p align="center">
  <b>Modificación de Datos de un Libro</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/f73e2d09-a006-4570-a34d-276236a8e742"><br>
</p>

Para la **Eliminación** de libros es necesario primeramente buscar el libro que sea desea eliminar por su ID de Copia, una vez encontrado el libro se habilitará el botón de **Eliminar Libro**  el cuál al presionarse se hará la eliminación correspondiente con el libro que se encontró en la búsqueda anteriormente realizada.

<p align="center">
  <b>Eliminación de un Libro</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/aa95137b-7e2f-4aa3-aef3-dba6958a98fb"><br>
</p>

  ## Administradores 
  + **Administrador**: Los usuarios de nivel Administradorn tendran que ingresar su ID de Usuario en el apartado de Ingresas. Despues de presionar el bontón ingresar, se iniciara otra ventana de ingreso de empleados donde se le pedira la contraseña al usuario para poder iniciar sesión

<p align="center">
  <b>Perfil de Administrador</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/6d448699-653b-405d-ac17-14ba29a8a563"><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/9e09e167-1e43-4123-9cff-3352abfe12de">
  <br><br>
  <b>Meodulos de Adminostrador</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/2372676c-26ed-421c-92c9-2a670634832d">
  <br><br>
</p>

### Control de Usuarios
En el módulo de Control de Usuarios se le muestra a Administrador un registro de todos los usuarios actualmente registrados con sus datos generales y su ID de Usuario Correspondiente, en la parte inferior 
del módulo se le permite al administrador realizar búsquedas de usuarios por los siguientes criterios: 

* Id de Usuario
* RFC

Además de las 2 operaciones adicionales de **Modificación  y Eliminación de Usuario** 

<p align="center">
  <b>Control de Usuarios</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/f56bebfb-790e-4c63-940f-398a1cf3b1bf"><br><br>
  <b>Tipos de Busqueda</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/864810b0-e905-44de-861e-3bb359f9fc53"><br><br>
</p>

#### Registrar Usuario y Colaborador
En los módulos de **Registrar Usuario y Registrar Colaborador** que se enucentran en le menú situado en la parte superior de la ventana, el administrador es capaz de dar de alta *usuarios de acceso general* 
en el módulo de **Registrar Usuario** y registrar usuarios con nivel acceso de **Administrador y Bibliotecario** en el Módulo de Registrar Colaborador, llenando los campos correspondientes que se solicitan que son datos generales de la persona a registrar.

<p align="center">
  <b>Registrar Usuarios</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/9b4ddba0-849d-4011-a19d-2faf44fe8658"><br><br>
  <b>Registrar Colaboradores</b><br>
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/8a567189-b641-4828-ae69-5bfa8af8a490"><br><br>
</p>

#### Modificar Usuario
Para la **Modificiación** de usuarios es necesario primeramente buscar el usuario que se deasea modificar por su ID de Usuario, una vez encontrado el usuario se despliegan los datos obtenidos del usuario encontrado y se pueden editar para realizar las modificaciones correspondientes, después de haber terminado los cambios correspondientes se confirman los cambios con el boton de **Aceptar Modificación**.

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/36fb103d-c1fa-4b6d-96a3-f9fbcf6f4d08"><br>
</p>

#### Eliminar Usuario
Para la **Eliminación** de Usuarios es necesario primeramente buscar el Usuario que sea desea eliminar por su ID de Usuario, una vez encontrado el Usuario se habilitará el botón de **Eliminar Usuario**  el cuál al presionarse se hará la eliminación correspondiente con el Usuario que se encontró en la búsqueda anteriormente realizada.

<p align="center">
  <img src = "https://github.com/EleazarRojo/Control-Bibliotecario/assets/134666855/de10dc6c-5cb6-4856-8384-1fab4c31572d"><br>
</p>

---
