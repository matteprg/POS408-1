'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Providers
    Public Property Id As Integer
    Public Property CompanyName As String
    Public Property Website As String
    Public Property Email As String
    Public Property LocationID As Integer
    Public Property ContactID As Integer

    Public Overridable Property Location As Locations
    Public Overridable Property Statuses As ICollection(Of Statuses) = New HashSet(Of Statuses)
    Public Overridable Property Contacts As ICollection(Of Contacts) = New HashSet(Of Contacts)

End Class
