# Super Systems

Liceo de Computación CSS
Grupo 02
5.º BCL “A”

---

Creamos una aplicación cuyo funcionamiento es ser un sistema de facturación, en nuestro caso también creamos una empresa cuyo nicho es ser el mayor proveedor de productos tecnológicos de manera sencilla a nuestros clientes y con un costo accesible.

Nuestra aplicación cuenta con distintas funciones como por ejemplo:

- Login (Autenticado con base de datos)
- Pantalla Inicial
- Facturación
- Ingresar productos
- Consultar Producto
- Modificar Producto

---

## 🔐Login:

Al iniciar el sistema de facturación contamos con un inicio de sesión (login) con base de datos, el usuario debe estar registrado por la administración de la empresa para poder ingresar al sistema, de lo contrario el programa mostrará un error de credenciales inválidas.

![login.gif](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/7532e546-f479-4d7b-a008-b9a7f5ff12f7/login.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220925%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220925T022337Z&X-Amz-Expires=86400&X-Amz-Signature=7924a9f6abb6547a2365b07f0ae6d5b3718c7433762faa97e41b211152fdd90c&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22login.gif%22&x-id=GetObject)

## 🖥️Pantalla Inicial:

Luego de haber accedido al sistema podrá llegar a la ventana del Menú,
acá podrá encontrar 4 opciones las cuales son:

1. Generar su recibo.
2. Ingresar un producto en específico.
3. Buscar algún producto no encontrado.
4. Modificar productos.

![pantallainicio.gif](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/99b11df4-365d-4453-9295-a8146474ce09/pantallainicio.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220925%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220925T022404Z&X-Amz-Expires=86400&X-Amz-Signature=c65e3952a3f3d430cba72c504ea60138e71a4f0b6f0194c2a63f9ebe23da7147&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22pantallainicio.gif%22&x-id=GetObject)

## 💳Facturación:

En esta opción del programa nosotros podremos generar una factura con los datos del cliente, productos, cantidad y total gastado.

![facturacion.gif](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/278a02f2-91a4-41ed-992a-55120f1fb02d/facturacion.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220925%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220925T022422Z&X-Amz-Expires=86400&X-Amz-Signature=cb9ade6858cd8560456ecf40b7fb1c9316c4a47d9138a1810313c0e405203801&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22facturacion.gif%22&x-id=GetObject)

## ➕Ingresar Productos:

En esta opción del sistema de facturación podemos agregar productos a nuestra base de datos para que en las demás opciones como “Consultar” o “editar” poder acceder a los productos que en esta opción de ingresar agreguemos. 

![ingresar.gif](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/be0c841d-8b02-4d97-9fd4-57a0ad411ba1/ingresar.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220925%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220925T022449Z&X-Amz-Expires=86400&X-Amz-Signature=ac96e5acc0aa7ea2e46acd38931e3af5e2a3958d41f6d298d76c707acac72c63&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22ingresar.gif%22&x-id=GetObject)

## 🔎Consultar Producto:

Cada producto lleva su número de serie o también llamado código para
poder identificarlo, entonces esta ventana necesita ya sea el código del
producto el nombre exacto para poder encontrarlo, al ser encontrado sé
darán los datos del precio, la garantía y la marca del producto.

![consultar.gif](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/c309bbfc-8dec-434e-8a99-d80fa252eff6/consultar.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220925%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220925T022507Z&X-Amz-Expires=86400&X-Amz-Signature=f711bb6a28a326e17b5d3309a07119c90bfa1ee075dcf81bede5477b90ddc874&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22consultar.gif%22&x-id=GetObject)

## 📝Modificar Producto:

En esta pestaña podremos modificar los productos de nuestra base de datos, eliminarlos, cambiar precio, descripción, garantía, etc.

![modi.gif](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/980565ba-b615-45c7-bb7c-e337cc64d27b/modi.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220925%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220925T022537Z&X-Amz-Expires=86400&X-Amz-Signature=6852e2557fd113b6db43f304d2161d5ac634cd37e5a614fd7d870a5d255d3f95&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22modi.gif%22&x-id=GetObject)
