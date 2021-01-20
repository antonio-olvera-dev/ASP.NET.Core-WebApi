# ASP.NET.Core-WebApi
## Instrucciones 📖
### Versión 1.6.3
### Instalación 🔨
##### Requisitos 
- Tener Instalado [Dotnet](https://dotnet.microsoft.com/download/dotnet/5.0) o estar en Windows
```sh
$ git clone https://github.com/antonioolvera1995/ASP.NET.Core-WebApi.git
```
### Iniciar 🚀
- Ejecutar .\asp.net-core-api\bin\Debug\netcoreapp3.1\asp.net-core-api.exe
- Si estas en Linux, Ubuntu... puedes ejecutar el siguente comando 
```sh
$ dotnet run 
```
### Uso
- Abrir Postman y hacer una petición GET en:  http://localhost:5000/users
- - Esta ruta devuelve todos los usuarios
- Abrir Postman y hacer una petición GET en:  http://localhost:5000/users/0
- - Esta ruta devuelve el primer nombre de la lista
- - modificar último valor por el numero deseado dentro del limite dado por la longitud de la lista.
- Abrir Postman y hacer una petición DELETE en:  http://localhost:5000/users/0
- - Esta ruta elimina el primer nombre de la lista
- - modificar último valor por el numero deseado dentro del limite dado por la longitud de la lista.
- Abrir Postman y hacer una petición POST en:  http://localhost:5000/users
- - Esta ruta agrega un nuevo usuario a la lista.
- - En el body especifique el nombre en formato JSON
```json
{
    "name":"Jose"
}
```
- Abrir Postman y hacer una petición PUT en:  http://localhost:5000/users/0
- - Esta ruta actualiza un nuevo usuario de la lista.
- - En el body especifique el nombre en formato JSON
```json
{
    "name":"nuevo nombre"
}
```
Lista inicial de los usuarios:
```cs
public static List<string> lista = new List<string> { "Antonio", "Pepe", "Juan", "Vicente", "Victor", "Pedro" };
```

