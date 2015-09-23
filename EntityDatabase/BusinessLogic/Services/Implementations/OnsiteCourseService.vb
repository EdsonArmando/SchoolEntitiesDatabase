Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports EntityDatabase.BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OnsiteCourseService
        Implements IOnsiteCourseService
        Public Function GetAllOnsiteCourse() As IQueryable(Of OnsiteCourse) Implements IOnsiteCourseService.GetAllOnsiteCourse
            Return DataContext.DBEntities.OnsiteCourses
        End Function
    End Class
End Namespace