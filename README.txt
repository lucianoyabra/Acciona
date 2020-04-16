
Test de Luciano Yabra para AccionaIT en proceso de incorporación a la empresa.

En la solución se exponen 2 endpoints para resolver las problematicas de Login y obtener la lat y lon especifico de una provincia deseada:

Con los Controladores de Login y Provincia especificamente, se recibiran las solicitudes GET a la api desarrollada, y se procesará la información que volverá en formato string.

Se incluye tambien el proyecto de test unitarios en los que se prueban las llamadas a cada una de las Apis expuestas.

LOGIN

El Login lo realicé suponiendo un solo usuario valido como lo indican. Asumí que tenía que inicializar los datos y no
simular una consulta ADO a una BDD SQL, sino tambien se puede invocar al server correspondiente y realizar la connsulta.

Devuevlo un string en formato JSON para el posterior manejo de datos a placer del solicitante.

No consideré excepciones de TypeMistmatch u otros ya que debería llegar la consulta con los string de user y password
previamente validada en el front.


PROVINCIA

En cuanto a la solucion de la provincia, realicé la consulta a la api en parte separada para
poder reutilizarlo en caso de ser necesario en otra parte del sistema.

Se hace engorroso quizá la busqueda de los datos deseados en el JSON obtenido por lo que
separo el JSON en partes para poder trabajar solamente con las provincias y luego de 
encontrar la deseada, sacar los datos particulares de cada una.

LOGGER 
Una clase encargada del manejo del archivo log.txt para guardar el LOG de eventos del programa.

