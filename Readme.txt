El administrador de una empresa del rubro automotriz le ha solicitado a usted, el
desarrollo de una aplicación para que los empleados puedan almacenar tareas
programadas con fecha y hora para el respaldo automático de la información generada
en los distintos sectores de la empresa. El procedimiento para almacenar una tarea es
la siguiente: seleccionar la fecha y hora de ejecución del respaldo, seleccionar el
usuario responsable, ingresar la contraseña del mismo, la ruta para realizar la copia, las
rutas de las carpetas a copiar y una observación sobre la copia.
Antes de almacenar una tarea se debe controlar que no exista una tarea con la fecha y
hora seleccionada, la fecha y la hora no puede ser menor a la fecha y la hora actual, la
contraseña del usuario debe ser correcta, la ruta destino tiene que ser correcta y se
tiene que haber elegido al menos una carpeta para copia, no permita copiar rutas de
carpetas repetidas y la carpeta destino nunca puede ser igual a una carpeta origen, en
todos los casos informe el error correspondiente.También el usuario tiene que poder ver todas las tareas almacenadas y poder anular
cualquier tarea que se encuentre pendiente de ejecutar. Los estados de las tareas son:
pendiente, terminada o anulada. De cada tarea se muestra la fecha, la hora, el nombre
del usuario responsable y el estado de la tarea.
El proceso temporizado se tiene que ejecutar cada 30 segundos. Este proceso es el
encargado de ejecutar todas las tareas pendientes al cumplirse la fecha y la hora
programada. Para llevar a cabo las tareas mencionadas anteriormente, se cuenta con
una base de datos que tiene tres tablas: ·
La tabla usuarios almacena un número para identificar al usuario, el nombre del
usuario y su contraseña, la clave principal de la tabla es el número de usuario. ·
La tabla tareas almacena la fecha y hora de ejecución de la tarea, el número de usuario
que generó la tarea, la ruta destino dónde se realizará la copia, una observación hecha
por el usuario y el estado de la tarea (0=pendiente, 1=terminada o 2=anulada), la clave
principal de la tabla está formada por las columnas fecha y hora. ·
La tabla carpetas almacena la fecha, la hora, el orden de la copia y la ruta de la carpeta a
copiar, la clave principal de la tabla está formada por las columnas fecha, hora y orden.