'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Course
    Public Property CourseID As Integer
    Public Property Title As String
    Public Property Credits As Integer
    Public Property DepartmentID As Integer

    Public Overridable Property Department As Department
    Public Overridable Property OnlineCourse As OnlineCourse
    Public Overridable Property OnsiteCourse As OnsiteCourse
    Public Overridable Property StudentGrades As ICollection(Of StudentGrade) = New HashSet(Of StudentGrade)
    Public Overridable Property People As ICollection(Of Person) = New HashSet(Of Person)

End Class