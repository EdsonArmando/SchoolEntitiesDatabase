Imports EntityDatabase.BusinessLogic.Helpers
Imports EntityDatabase.BusinessLogic.Services.Implementations
Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Namespace Modules.OfficesAssignment.ViewModels
    Public Class OfficesAssignmentViewModel
        Inherits ViewModelBase

        Private _officesAssignment As ObservableCollection(Of OfficeAssignment)
        Private dataAccess As IOfficeAssignmentService

        Public Property OfficeAssignment As ObservableCollection(Of OfficeAssignment)
            Get
                Return Me._officesAssignment
            End Get
            Set(value As ObservableCollection(Of OfficeAssignment))
                Me._officesAssignment = value
                OnPropertyChanged("OfficeAssignment")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOfficeAssignment() As IQueryable(Of OfficeAssignment)
            Return Me.dataAccess.GetAllOfficeAssignment

        End Function
        Sub New()
            'Initialize property variable of departments
            Me._officesAssignment = New ObservableCollection(Of OfficeAssignment)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOfficeAssignmentService)(New OfficeAssignmentService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOfficeAssignmentService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOfficeAssignment
                Me._officesAssignment.Add(element)
            Next
        End Sub
    End Class
End Namespace