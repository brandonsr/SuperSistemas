﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SuperSistemas.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Consultar_producto() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Consultar_producto", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property facturacion() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("facturacion", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property icon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Icon similar a (Icono).
        '''</summary>
        Public ReadOnly Property icon1() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("icon1", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Ingresar_producto() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Ingresar_producto", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property login() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("login", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property loginface() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("loginface", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Modificar_producto() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Modificar_producto", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
