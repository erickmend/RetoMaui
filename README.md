# RetoMaui

## Notas generales y decisiones tomadas

### Vistas
Utilicé únicamente `ContentPage`. Esta decisión se tomó para poder utilizar `Shell`, aunque en este caso solo lo empleé para la navegación de vistas. En mi experiencia, la navegación con `Shell` es más sencilla, ya que se basa en rutas (las cuales defino en el *code-behind* de mi `Shell`).

---

### Plugin.FingerPrint
No utilicé el plugin recomendado, ya que al leer la documentación no encontré soporte para .NET MAUI, solo para Xamarin. En su lugar, seguí una recomendación del YouTuber/Influencer/Dev Gerald Versluis. Es bastante fácil de integrar, solo hay que configurar el `AndroidManifest.xml` y el `Info.plist`.

🔗 [Repositorio del plugin](https://github.com/FreakyAli/Plugin.Maui.Biometric)

---

### Requestor
Técnicamente, el `Requestor` debería estar en la capa de infraestructura, pero lo dejé como un proyecto aparte. Esto se debe a que MAUI permite compartir bibliotecas de clases con otros proyectos, lo que facilita la integración con Blazor, Web API, WPF u otros clientes dentro del ecosistema .NET.

Por esta razón, se trata de una biblioteca de clases normal y no exclusivamente de MAUI.

---

### SecureStorage
Tuve problemas al utilizar `SecureStorage`, no por su implementación (de hecho, ya está implementado), sino por el entorno de iOS. Al momento de compilar, el sistema me solicita los certificados de desarrollo.

---

### Internacionalización
El manejo de idiomas lo hice mediante archivos de recursos. Sinceramente, no me gusta inyectar estos archivos en todos mis `ViewModels`, por lo que esta parte podría mejorarse.

---

### HttpClient
Utilicé la API pública de Chuck Norris:

🔗 [https://api.chucknorris.io/](https://api.chucknorris.io/)

Implementé los métodos para solicitar datos por REST, pero en el reto solo estoy usando `GET`, descartando `POST`, `PUT` y `DELETE`.

---

### Unit Tests
Las pruebas unitarias solo cubren los casos del servicio de Chuck Norris.

📷 ![image](https://github.com/user-attachments/assets/4b5d3704-7c76-412e-9a50-39451c83775d)

---

### OAUTH v2 con MSAL
Me quedé en la fase de investigación en Azure. Comencé a configurar los recursos en mi directorio personal de Azure, pero no pude avanzar más por falta de tiempo. Continuaré con esto la próxima semana.

---

### Archivo YAML
Al igual que con `MSAL`, no me alcanzó el tiempo para trabajar en esto. Es una curva de aprendizaje que aún no he tomado, pero en los próximos días me pondré manos a la obra con el despliegue como reto personal.

---

### Video funcional
 https://youtu.be/SsKPFj4WJYA?si=KqBTlqI4w5sWi06Q
---
