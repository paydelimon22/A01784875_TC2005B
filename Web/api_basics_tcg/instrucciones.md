# Instrucciones
Desarrollar el código de un servidor que tenga un API para manipular información de cartas. Las cartas deben de guardarse en una lista dentro del mismo servidor. Diseña las rutas que el API debe de tener para poder hacer lo siguiente:

- Debe de regresar todas las cartas que estén almacenadas. Si no hay cartas, envía un mensaje de que no hay cartas.
- Debe de regresar solo una carta en base a un ID. Verifica que la carta exista antes de enviar algo. En caso de que la carta no exista, regresa un mensaje indicándolo.
- Debe de recibir un json con las cartas nuevas que se van a agregar a la lista. Verifica que las cartas tengan todos los atributos antes de agregarlas a la lista. Verifica que no exista la carta en la lista antes de intentar agregarla. En caso de que no se pueda agregar, envía un mensaje de que no se pudo agregar en un json, con el código de estado adecuado. En caso de que sí se haya agregado, regresa un mensaje en un json de que sí se agregó correctamente.
- Debe de poder borrar una carta en base a su ID. Verifica que la carta exista antes de borrarla de la lista.
- Debe de poder actualizar una carta en base a su ID. Recibe los campos que se van a actualizar en un json, y solo actualiza los campos que vienen en el json. Verifica que la carta exista antes de intentar actualizarla.
