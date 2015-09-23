Imports EntityDatabase.BusinessLogic.Helpers
Imports EntityDatabase.BusinessLogic.Services.Implementations
Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.OnsiteCourses.ViewModels
    Public Class OnsiteCoursesViewModel
        Inherits ViewModelBase

        Private _onsiteCourses As ObservableCollection(Of OnsiteCourse)
        Private dataAccess As IOnsiteCourseService

        Public Property OnsiteCourses As ObservableCollection(Of OnsiteCourse)
            Get
                Return Me._onsiteCourses
            End Get
            Set(value As ObservableCollection(Of OnsiteCourse))
                Me._onsiteCourses = value
                OnPropertyChanged("OnsiteCourses")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOnsiteCourse() As IQueryable(Of OnsiteCourse)
            Return Me.dataAccess.GetAllOnsiteCourse
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._onsiteCourses = New ObservableCollection(Of OnsiteCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOnsiteCourseService)(New OnsiteCourseService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOnsiteCourseService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOnsiteCourse
                Me._onsiteCourses.Add(element)
            Next
        End Sub
    End Class
End Namespace

