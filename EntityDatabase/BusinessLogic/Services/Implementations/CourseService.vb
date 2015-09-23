Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports EntityDatabase.BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class CourseService
        Implements ICourseService
        Public Function GetAllCourses() As IQueryable(Of Course) Implements ICourseService.GetAllCourses
            Return DataContext.DBEntities.Courses
        End Function
    End Class
End Namespace
