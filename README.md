# Interfaces Inteligentes. Práctica 8. Micro y Cámara.

En el siguiente repositorio se encuentran las diferentes soluciones propuestas para la práctica 8 de Interfaces Inteligentes

## Ejercicios

### Ejercicio 1.
Para llevar a cabo este ejercicio, se ha realizado un pequeño [script](/scripts/MovimientoSoldados.cs) para conseguir que ambos soldados avancen hacia un punto situado en el centro del terreno. Por otra parte, también se ha desarrollado un [notificador](/scripts/NotificadorColisionHumanoide.cs) que se lanza al momento de la colisión entre soldados y al que el GameObject `Audio Source` se podrá suscribir para conocer el momento en el que se produce. 

Finalmente, se ha generado un último [script](/scripts/ReproduceAudio.cs) para suscribir al `Audio Source` al notificador previamente desarrollado. De esta manera, al recibir que se ha producido una colisión, se reproduce la pista que el GameObject tiene como `Audio Resource`.


[Enlace al video demostrativo.](https://drive.google.com/file/d/1FbQU3C4-778kEzMs7ZxpvPsOlYp_gwxK/view?usp=drive_link)

---

### Ejercicio 2.

En este caso, se ha importado un [asset de televisor antiguo](https://assetstore.unity.com/packages/3d/props/electronics/vintage-tv2-220276) desde la **Unity Asset Store** y un [modelo de altavoz](https://sketchfab.com/3d-models/stage-speaker-black-f3209a6a45b844df92560099f982a508) desde **Sketchfab**. 

Luego, se ha añadido a los altavoces un component `Audio Source` para que puedan reproducir sonido y se ha creado el siguiente [script](/scripts/Grabadora.cs), donde se especifica la lógica para realizar grabaciones de 5 segundos al captar el input `Fire1` y reproducirlo al captar `Fire2`.

[Enlace al video demostrativo.](https://drive.google.com/file/d/1rClrhMuesqJPxFE_lVEX5hIbdJBk_Plx/view?usp=drive_link)

---

### Ejercicio 3.
Por último, se ha añadido un plano al que se le ha agregado el siguiente [script](/scripts/MaterialWebCam.cs) (no se le ha agregado directamente a la TV ya que tienen su propio material y al cambiarlo el resultado no era el esperado). En dicho script se especifican las diferentes acciones a realizar al captar el input de diferentes teclas. Dichas acciones se describen a continuación.

* **Pulsar la tecla S:** Cambia el color del material del plano a blanco, hace que la textura principal del material pase a ser `WebCamTexture` e inicia la textura con el método `Play()`.
* **Pulsar la tecla P:** Detiene la reproducción de la textura con el método `Stop()`, cambia la textura principal del material a la que tenía originalmente y devuelve el color original.
* **Pulsar la tecla X:** Crea una variable de tipo `Texture2D` y almacena en ella los píxeles de la `WebCamTexture` en el momento en que se registó la pulsación. Finalmente, salva el contenido de la textura en la ruta especificada como atributo privado en formato **.png**.

