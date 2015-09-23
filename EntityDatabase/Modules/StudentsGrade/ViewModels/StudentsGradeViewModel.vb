Imports EntityDatabase.BusinessLogic.Helpers
Imports EntityDatabase.BusinessLogic.Services.Implementations
Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Namespace Modules.StudentsGrade.ViewModels
    Public Class StudentsGradeViewModel
        Inherits ViewModelBase

        Private _studentsGrade As ObservableCollection(Of StudentGrade)
        Private dataAccess As IStudentGradeService

        Public Property StudentsGrade As ObservableCollection(Of StudentGrade)
            Get
                Return Me._studentsGrade
            End Get
            Set(value As ObservableCollection(Of StudentGrade))
                Me._studentsGrade = value
                OnPropertyChanged("StudentsGrade")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllStudentsGrade() As IQueryable(Of StudentGrade)
            Return Me.dataAccess.GetAllStudentsGrade
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._studentsGrade = New ObservableCollection(Of StudentGrade)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IStudentGradeService)(New StudentGradeService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IStudentGradeService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllStudentsGrade
                Me._studentsGrade.Add(element)
            Next
        End Sub
    End Class
End Namespace